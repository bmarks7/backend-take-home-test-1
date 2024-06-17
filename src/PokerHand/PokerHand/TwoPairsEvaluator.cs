using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHand
{
	public class TwoPairsEvaluator : IHandTypeEvaluator
    {
        public HandTypeRanking HandType => HandTypeRanking.TwoPairs;

        public bool IsHand(Card[] cards)
        {
            // Check if there are two distinct pairs
            var groups = cards.GroupBy(c => c.GetValue());
            return groups.Count(g => g.Count() == 2) == 2;
        }

        // Compares two hands that are both flush
        public Hand GetHigherRankingHand(Hand hand1, Hand hand2)
        {
            List<CardValue> player1SortedCardValues = getSortedCardValues(hand1);
            List<CardValue> player2SortedCardValues = getSortedCardValues(hand2);

            // Compares the highest pair from each hand
            CardValue player1HigherPairValue = GetValuesThatAppearMultipleTimes(player1SortedCardValues, 2).Max();
            CardValue player2HigherPair1Value = GetValuesThatAppearMultipleTimes(player2SortedCardValues, 2).Max();

            if (player1HigherPairValue > player2HigherPair1Value)
            {
                return hand1;
            }
            else if (player1HigherPairValue < player2HigherPair1Value)
            {
                return hand2;
            }

            RemoveAllInstances(player1SortedCardValues, player1HigherPairValue);
            RemoveAllInstances(player2SortedCardValues, player2HigherPair1Value);

            // Compares the lower pair from each hand
            CardValue player1LowerPairValue = GetValuesThatAppearMultipleTimes(player1SortedCardValues, 2)[0];
            CardValue player2LowerPair1Value = GetValuesThatAppearMultipleTimes(player2SortedCardValues, 2)[0];

            if (player1LowerPairValue > player2LowerPair1Value)
            {
                return hand1;
            }
            else if (player1LowerPairValue < player2LowerPair1Value)
            {
                return hand2;
            }

            RemoveAllInstances(player1SortedCardValues, player1LowerPairValue);
            RemoveAllInstances(player2SortedCardValues, player2LowerPair1Value);

            // Compares the last remaining card
            if (player1SortedCardValues[0] > player2SortedCardValues[0])
            {
                return hand1;
            }

            else if (player1SortedCardValues[0] < player2SortedCardValues[0])
            {
                return hand2;
            }

            return null;
        }

        private List<CardValue> getSortedCardValues(Hand playerHand)
        {
            return playerHand.GetCards().Select(card => card.GetValue()).OrderByDescending(value => value).ToList();
        }



        // Extracts the card value from cardValues that appears {numberOfDuplicates} times
        public static List<CardValue> GetValuesThatAppearMultipleTimes(List<CardValue> cardValues, int numberOfDuplicates)
        {
            return cardValues.GroupBy(value => value)
                             .Where(group => group.Count() == numberOfDuplicates)
                             .Select(group => group.Key)
                             .ToList();
        }

        // Removes all instances of a particular value from a list of cards
        public static void RemoveAllInstances(List<CardValue> list, CardValue value)
        {
            list.RemoveAll(x => x == value);
        }
    }
}

