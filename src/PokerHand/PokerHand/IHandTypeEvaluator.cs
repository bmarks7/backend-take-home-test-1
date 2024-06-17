using System;
namespace PokerHand
{
    public interface IHandTypeEvaluator
    {
        HandTypeRanking HandType { get; }
        bool IsHand(Card[] cards);
        Hand GetHigherRankingHand(Hand hand1, Hand hand2);
    }
}

