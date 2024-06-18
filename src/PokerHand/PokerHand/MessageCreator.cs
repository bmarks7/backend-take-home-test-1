using System;
namespace PokerHand
{
	public class MessageCreator
	{
		public MessageCreator()
		{
        }

        public string GetWinnerMessage(PlayerNumber playerNum)
        {
            return ($"\nPlayer {playerNum.ToString()} has higher rank and wins");
        }

        public string GetTieMessage()
        {
            return "\nIt's a tie";
        }
    }
}

