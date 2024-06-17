using System;

namespace PokerHand
{
    public class Card
    {
        private CardSuit suit;
        private CardValue value;

        public Card(CardSuit suit, CardValue value)
        {
            // Validate suit
            if (!Enum.IsDefined(typeof(CardSuit), suit))
            {
                throw new ArgumentException("Invalid card suit.");
            }

            // Validate value
            if (!Enum.IsDefined(typeof(CardValue), value))
            {
                throw new ArgumentException("Invalid card value.");
            }

            this.suit = suit;
            this.value = value;
        }

        public CardSuit GetSuit()
        {
            return suit;
        }

        public CardValue GetValue()
        {
            return value;
        }
    }
}
