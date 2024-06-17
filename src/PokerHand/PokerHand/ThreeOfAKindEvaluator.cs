using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHand
{
	public class ThreeOfAKindEvaluator : IHandTypeEvaluator
    {
        public HandTypeRanking HandType => HandTypeRanking.ThreeOfAKind;

        public bool IsHand(Card[] cards)
        {
            // Check if any three cards have the same value
            return cards.GroupBy(c => c.GetValue()).Any(g => g.Count() == 3);
        }

        // Compares two hands that are both flush
        public Hand GetHigherRankingHand(Hand hand1, Hand hand2)
        {
            List<CardValue> player1SortedCardValues = getSortedCardValues(hand1);
            List<CardValue> player2SortedCardValues = getSortedCardValues(hand2);

            // Compares the value of the cards making the three of a kind in each hand
            CardValue player1ThreeOfAKindValue = GetValuesThatAppearMultipleTimes(player1SortedCardValues, 3)[0];
            CardValue player2ThreeOfAKindValue = GetValuesThatAppearMultipleTimes(player2SortedCardValues, 3)[0];

            if (player1ThreeOfAKindValue > player2ThreeOfAKindValue)
            {
                return hand1;
            }

            else if (player1ThreeOfAKindValue < player2ThreeOfAKindValue)
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

