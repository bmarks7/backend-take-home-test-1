using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHand
{
	public class EqualRankingHandler
	{
        private MessageCreator messageCreator;
        private HighCardEvaluator highCardEvaluator = new HighCardEvaluator();
        private PairEvaluator pairEvaluator = new PairEvaluator();
        private TwoPairsEvaluator twoPairsEvaluator = new TwoPairsEvaluator();
        private ThreeOfAKindEvaluator threeOfAKindEvaluator = new ThreeOfAKindEvaluator();
        private FlushEvaluator flushEvaluator = new FlushEvaluator();

        public EqualRankingHandler()
        {
            messageCreator = new MessageCreator();
        }

        public string HandleEqualRank(Hand player1Hand, Hand player2Hand)
        {
            HandTypeRanking player1Rank = player1Hand.GetHandRanking();
            HandTypeRanking player2Rank = player2Hand.GetHandRanking();

            Hand higherRankingHand;

            // Depending on what the ranking the two hands are, we will compare them further so see which one is higher ranking
            if (player2Rank == HandTypeRanking.HighCard && player1Rank == HandTypeRanking.HighCard)
            {
                higherRankingHand = highCardEvaluator.GetHigherRankingHand(player1Hand, player2Hand);
            }

            else if (player2Rank == HandTypeRanking.Pair && player1Rank == HandTypeRanking.Pair)
            {
                higherRankingHand = pairEvaluator.GetHigherRankingHand(player1Hand, player2Hand);

            }

            else if (player2Rank == HandTypeRanking.TwoPairs && player1Rank == HandTypeRanking.TwoPairs)
            {
                higherRankingHand = twoPairsEvaluator.GetHigherRankingHand(player1Hand, player2Hand);
            }

            else if (player2Rank == HandTypeRanking.ThreeOfAKind && player1Rank == HandTypeRanking.ThreeOfAKind)
            {
                higherRankingHand = threeOfAKindEvaluator.GetHigherRankingHand(player1Hand, player2Hand);
            }

            else
            {
                higherRankingHand = flushEvaluator.GetHigherRankingHand(player1Hand, player2Hand);
            }


            // Return appropriate message depending on the result of the comparison of the hands
            if (higherRankingHand == player1Hand)
            {
                return messageCreator.GetWinnerMessage(PlayerNumber.one);
            }
            else if (higherRankingHand == player2Hand)
            {
                return messageCreator.GetWinnerMessage(PlayerNumber.two);
            }
            else
            {
                return messageCreator.GetTieMessage();
            }
        }
    }
}

