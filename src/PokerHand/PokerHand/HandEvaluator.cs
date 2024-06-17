using System;
using System.Linq;

namespace PokerHand
{
	public class HandEvaluator
	{
        private readonly Card[] cards;
        private HighCardEvaluator highCardEvaluator = new HighCardEvaluator();
        private PairEvaluator pairEvaluator = new PairEvaluator();
        private TwoPairsEvaluator twoPairsEvaluator = new TwoPairsEvaluator();
        private ThreeOfAKindEvaluator threeOfAKindEvaluator = new ThreeOfAKindEvaluator();
        private FlushEvaluator flushEvaluator = new FlushEvaluator();
        
        
        public HandEvaluator(Card[] cards)
        {
            this.cards = cards;
        }

        // We check what type of hand the cards classify as
        public HandTypeRanking EvaluateHandRanking()
        {
            if (flushEvaluator.IsHand(cards))
            {
                return flushEvaluator.HandType;
            }
            else if (threeOfAKindEvaluator.IsHand(cards))
            {
                return threeOfAKindEvaluator.HandType;
            }
            else if (twoPairsEvaluator.IsHand(cards))
            {
                return twoPairsEvaluator.HandType;
            }
            else if (pairEvaluator.IsHand(cards))
            {
                return pairEvaluator.HandType;
            }
            else
            {
                return highCardEvaluator.HandType;
            }
        }
    }
}

