using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHand
{
	public class HighCardEvaluator : IHandTypeEvaluator
    {
        public HandTypeRanking HandType => HandTypeRanking.HighCard;

        public bool IsHand(Card[] cards)
        {
            // I will leave it like this for now
            return true;
        }

        // Compares two hands that are both flush
        public Hand GetHigherRankingHand(Hand hand1, Hand hand2)
        {
            List<CardValue> player1SortedCardValues = getSortedCardValues(hand1);
            List<CardValue> player2SortedCardValues = getSortedCardValues(hand2);

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

            return null;
        }

        private List<CardValue> getSortedCardValues(Hand playerHand)
        {
            return playerHand.GetCards().Select(card => card.GetValue()).OrderByDescending(value => value).ToList();
        }
    }
}

