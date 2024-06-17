using PokerHand;
using Xunit;
using FluentAssertions;

namespace PokerHandTest
{
    public class UnitTest1
    {
        [Fact]
        public void HighCard_and_Pair()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Five);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Seven);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card Player2Card1 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Two);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Four);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Five);
            Card Player2Card5 = new Card(CardSuit.C, CardValue.Six);

            Card[] Player1Cards = new Card[] {Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5};
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void HighCard_and_TwoPairs()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Five);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Seven);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card Player2Card1 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Two);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Four);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Four);
            Card Player2Card5 = new Card(CardSuit.C, CardValue.Six);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void HighCard_and_ThreeOfAKind()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Five);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Seven);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card Player2Card1 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Two);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Two);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Four);
            Card Player2Card5 = new Card(CardSuit.C, CardValue.Six);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void HighCard_and_Flush()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Five);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Seven);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card Player2Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player2Card2 = new Card(CardSuit.C, CardValue.Five);
            Card Player2Card3 = new Card(CardSuit.C, CardValue.Six);
            Card Player2Card4 = new Card(CardSuit.C, CardValue.Seven);
            Card Player2Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void Pair_and_TwoPairs()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Four);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Seven);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card Player2Card1 = new Card(CardSuit.D, CardValue.Four);
            Card Player2Card2 = new Card(CardSuit.S, CardValue.Four);
            Card Player2Card3 = new Card(CardSuit.C, CardValue.Six);
            Card Player2Card4 = new Card(CardSuit.D, CardValue.Two);
            Card Player2Card5 = new Card(CardSuit.C, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void Pair_and_ThreeOfAKind()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Four);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Seven);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card Player2Card1 = new Card(CardSuit.D, CardValue.Two);
            Card Player2Card2 = new Card(CardSuit.H, CardValue.Two);
            Card Player2Card3 = new Card(CardSuit.S, CardValue.Two);
            Card Player2Card4 = new Card(CardSuit.C, CardValue.Seven);
            Card Player2Card5 = new Card(CardSuit.C, CardValue.Six);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void Pair_and_Flush()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Four);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Seven);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card Player2Card1 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card2 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card3 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card4 = new Card(CardSuit.C, CardValue.Seven);
            Card Player2Card5 = new Card(CardSuit.C, CardValue.Six);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void TwoPairs_and_ThreeOfAKind()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Four);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card Player2Card1 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Two);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Two);
            Card Player2Card4 = new Card(CardSuit.C, CardValue.Seven);
            Card Player2Card5 = new Card(CardSuit.C, CardValue.Six);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void TwoPairs_and_Flush()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Four);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card Player2Card1 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card2 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card3 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card4 = new Card(CardSuit.C, CardValue.Seven);
            Card Player2Card5 = new Card(CardSuit.C, CardValue.Six);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void ThreeOfAKind_and_Flush()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Four);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Four);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Four);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Eight);

            Card Player2Card1 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card2 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card3 = new Card(CardSuit.C, CardValue.Two);
            Card Player2Card4 = new Card(CardSuit.C, CardValue.Seven);
            Card Player2Card5 = new Card(CardSuit.C, CardValue.Six);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void HighCard_and_HighCard_HighestNumberEqual_OtherNumberNotEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Ten);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Eight);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Four);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.S, CardValue.Ten);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Eight);
            Card Player2Card3 = new Card(CardSuit.C, CardValue.Six);
            Card Player2Card4 = new Card(CardSuit.C, CardValue.Three);
            Card Player2Card5 = new Card(CardSuit.S, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void HighCard_and_HighCard_HighestNumberNotEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Ten);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Eight);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Four);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.S, CardValue.Queen);
            Card Player2Card2 = new Card(CardSuit.H, CardValue.Eight);
            Card Player2Card3 = new Card(CardSuit.C, CardValue.Six);
            Card Player2Card4 = new Card(CardSuit.C, CardValue.Three);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void HighCard_and_HighCard_Equal()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Ten);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Eight);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Four);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.H, CardValue.Ten);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Eight);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Four);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetTieMessage());

        }

        [Fact]
        public void Pair_and_Pair_PairNotEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Ten);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Ten);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Three);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.H, CardValue.Jack);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Jack);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Four);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }


        [Fact]
        public void Pair_and_Pair_PairEqual_OtherNumsNotEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Jack);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Jack);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Three);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.H, CardValue.Jack);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Jack);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Four);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void Pair_and_Pair_Equal()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Jack);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Jack);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Three);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.H, CardValue.Jack);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Jack);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Three);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetTieMessage());

        }

        [Fact]
        public void TwoPairs_and_TwoPairs_HighestPairsNotEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Jack);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Jack);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Five);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.H, CardValue.Queen);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Queen);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void TwoPairs_and_TwoPairs_HigherPairsEqual_LowerPairsNotEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Queen);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Queen);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Five);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Five);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.H, CardValue.Queen);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Queen);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void TwoPairs_and_TwoPairs_HigherPairsEqual_LowerPairsEqual_RemainingCardsNotEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Queen);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Queen);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.H, CardValue.Queen);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Queen);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Five);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void TwoPairs_and_TwoPairs_Equal()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Queen);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Queen);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.H, CardValue.Queen);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Queen);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Six);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetTieMessage());

        }

        [Fact]
        public void ThreeOfAKind_and_ThreeOfAKind_ThreeCardsNotEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Ten);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Ten);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Ten);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.H, CardValue.Queen);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Queen);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Queen);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void ThreeOfAKind_and_ThreeOfAKind_ThreeCardsEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Ten);
            Card Player1Card2 = new Card(CardSuit.D, CardValue.Ten);
            Card Player1Card3 = new Card(CardSuit.H, CardValue.Ten);
            Card Player1Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.H, CardValue.Ten);
            Card Player2Card2 = new Card(CardSuit.D, CardValue.Ten);
            Card Player2Card3 = new Card(CardSuit.H, CardValue.Ten);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Six);
            Card Player2Card5 = new Card(CardSuit.D, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetTieMessage());

        }

        [Fact]
        public void Flush_and_Flush__HighestNumberEqual_OtherNumberNotEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Six);
            Card Player1Card2 = new Card(CardSuit.C, CardValue.Seven);
            Card Player1Card3 = new Card(CardSuit.C, CardValue.Ten);
            Card Player1Card4 = new Card(CardSuit.C, CardValue.Jack);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.S, CardValue.Six);
            Card Player2Card2 = new Card(CardSuit.S, CardValue.Eight);
            Card Player2Card3 = new Card(CardSuit.S, CardValue.Ten);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Jack);
            Card Player2Card5 = new Card(CardSuit.S, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void Flush_and_Flush__HighestNumberNotEqual()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Six);
            Card Player1Card2 = new Card(CardSuit.C, CardValue.Seven);
            Card Player1Card3 = new Card(CardSuit.C, CardValue.Ten);
            Card Player1Card4 = new Card(CardSuit.C, CardValue.Jack);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.S, CardValue.Six);
            Card Player2Card2 = new Card(CardSuit.S, CardValue.Eight);
            Card Player2Card3 = new Card(CardSuit.S, CardValue.Ten);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Ace);
            Card Player2Card5 = new Card(CardSuit.S, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetWinnerMessage(PlayerNumber.two));

        }

        [Fact]
        public void Flush_and_Flush__Equal()
        {

            //Arrange
            Card Player1Card1 = new Card(CardSuit.C, CardValue.Six);
            Card Player1Card2 = new Card(CardSuit.C, CardValue.Seven);
            Card Player1Card3 = new Card(CardSuit.C, CardValue.Ten);
            Card Player1Card4 = new Card(CardSuit.C, CardValue.Jack);
            Card Player1Card5 = new Card(CardSuit.C, CardValue.Two);

            Card Player2Card1 = new Card(CardSuit.S, CardValue.Six);
            Card Player2Card2 = new Card(CardSuit.S, CardValue.Seven);
            Card Player2Card3 = new Card(CardSuit.S, CardValue.Ten);
            Card Player2Card4 = new Card(CardSuit.S, CardValue.Jack);
            Card Player2Card5 = new Card(CardSuit.S, CardValue.Two);

            Card[] Player1Cards = new Card[] { Player1Card1, Player1Card2, Player1Card3, Player1Card4, Player1Card5 };
            Card[] Player2Cards = new Card[] { Player2Card1, Player2Card2, Player2Card3, Player2Card4, Player2Card5 };

            Hand Player1Hand = new Hand(Player1Cards);
            Hand Player2Hand = new Hand(Player2Cards);

            PokerGame pokerGame = new PokerGame(Player1Hand, Player2Hand);
            MessageCreator messageCreator = new MessageCreator();

            //Act
            string gameResult = pokerGame.GetGameResult();

            //Assert
            gameResult.Should().Be(messageCreator.GetTieMessage());

        }
    }
}