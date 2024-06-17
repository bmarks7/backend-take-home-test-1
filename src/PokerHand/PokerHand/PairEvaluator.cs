using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHand
{
	public class PairEvaluator : IHandTypeEvaluator
    {
        public HandTypeRanking HandType => HandTypeRanking.Pair;

        public bool IsHand(Card[] cards)
        {
            // Check if there is exactly one pair
            var groups = cards.GroupBy(c => c.GetValue());
            return groups.Any(g => g.Count() == 2);
        }

        // Compares two hands that are both flush
        public Hand GetHigherRankingHand(Hand hand1, Hand hand2)
        {
            List<CardValue> player1SortedCardValues = getSortedCardValues(hand1);
            List<CardValue> player2SortedCardValues = getSortedCardValues(hand2);

            // Compares the pair value from each hand
            CardValue player1PairValue = GetValuesThatAppearMultipleTimes(player1SortedCardValues, 2)[0];
            CardValue player2PairValue = GetValuesThatAppearMultipleTimes(player2SortedCardValues, 2)[0];

            if (player1PairValue > player2PairValue)
            {
                return hand1;
            }

            else if (player1PairValue < player2PairValue)
            {
                return hand2;
            }

            // Compares the values of the cards not in the pair from each hand
            else
            {
                RemoveAllInstances(player1SortedCardValues, player1PairValue);
                RemoveAllInstances(player2SortedCardValues, player2PairValue);

                for (int i = 0; i < player1SortedCardValues.Count; i++)
                {
                    if (player1SortedCardValues[i] > player2SortedCardValues[i])
                    {
                        return hand1;
                    }

                    else if (player1SortedCardValues[i] < player2SortedCardValues[i])
                    {
                        return hand2;
                    }
                }
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

