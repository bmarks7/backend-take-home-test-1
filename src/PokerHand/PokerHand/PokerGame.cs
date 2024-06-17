using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHand
{
	public class PokerGame
	{
        private Hand player1Hand;
        private Hand player2Hand;
        private MessageCreator messageCreator;
        private EqualRankingHandler equalRankingHandler;

        public PokerGame(Hand hand1, Hand hand2)
		{
            player1Hand = hand1;
            player2Hand = hand2;
            messageCreator = new MessageCreator();
            equalRankingHandler = new EqualRankingHandler();
        }

		public string GetGameResult()
		{
			HandTypeRanking player1Rank = player1Hand.GetHandRanking();
			HandTypeRanking player2Rank = player2Hand.GetHandRanking();

            // Compare the ranks to determine the winner
            if (player1Rank > player2Rank)
            {
                return messageCreator.GetWinnerMessage(PlayerNumber.one);
            }
            else if (player2Rank > player1Rank)
            {
                return messageCreator.GetWinnerMessage(PlayerNumber.two);
            }
            else
            {
                // If two hands have the same rank
                return equalRankingHandler.HandleEqualRank(player1Hand, player2Hand);
            }
        }
	}
}

