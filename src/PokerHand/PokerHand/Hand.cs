using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHand
{
	public class Hand
	{
        private Card[] cards;
        private const int handSize = 5;
        private HandEvaluator handEvaluator;

        // Ensures only hands with exactly 5 cards are allowed
        public Hand(Card[] newCards)
        {
            if (newCards == null)
            {
                throw new ArgumentNullException(nameof(newCards));
            }

            if (newCards.Length != handSize)
            {
                throw new ArgumentException($"Hand must contain exactly {handSize} cards.");
            }

            cards = newCards;
            handEvaluator = new HandEvaluator(cards);
        }

        public Card[] GetCards()
        {
            return cards;
        }

        // Determines hand ranking
        public HandTypeRanking GetHandRanking()
        {
            return handEvaluator.EvaluateHandRanking();
        }
    }
}

