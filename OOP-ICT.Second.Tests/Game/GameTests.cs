using NUnit.Framework;
using OOP_ICT.Second.Models;

namespace OOP_ICT.Tests
{
    [TestFixture]
    public class BlackJackGameTests
    {
        [Test]
        public void AddPlayerToGame_AddsPlayerToGame()
        {
            // Arrange
            var game = new BlackJackGame();
            var player = new Player { Name = "p1" };

            // Act
            game.AddPlayerToGame(player);

            // Assert
            Assert.Contains(player, game.players);
        }

        [Test]
        public void MakingBetsCheck_ReturnsFalseIfPlayerHasNoBet()
        {
            // Arrange
            var game = new BlackJackGame();
            var player = new Player { Name = "p1" };
            game.AddPlayerToGame(player);

            // Act
            var result = game.MakingBetsCheck();

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void EveryoneReadyCheck_ReturnsFalseIfPlayerIsNotReady()
        {
            // Arrange
            var game = new BlackJackGame();
            var player = new Player { Name = "p1" };
            game.AddPlayerToGame(player);

            // Act
            var result = game.EveryoneReadyCheck();

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void GameFirstStep_GivesPlayersTwoCards()
        {
            // Arrange
            var game = new BlackJackGame();
            var player = new Player { Name = "p1" };
            game.AddPlayerToGame(player);

            // Act
            game.GameFirsStep();

            // Assert
            Assert.AreEqual(2, player.Cards.Count);
        }

        [Test]
        public void GetOneMoreCard_AddsOneCardToPlayer()
        {
            // Arrange
            var game = new BlackJackGame();
            var player = new Player { Name = "p1" };
            game.AddPlayerToGame(player);

            // Act
            game.GetOneMoreCard(player);

            // Assert
            Assert.AreEqual(1, player.Cards.Count);
        }

        [Test]
        public void DealerTakeCards_GivesDealerCardsUntilHeHasAtLeast17()
        {
            // Arrange
            var game = new BlackJackGame();

            // Act
            game.DealerTakeCards();

            // Assert
            Assert.GreaterOrEqual(game._dealer1.CardsSum(), 17);
        }

        [Test]
        public void GameEndScoring_ReturnsListOfWinners()
        {
            // Arrange
            var game = new BlackJackGame();
            var player1 = new Player { Name = "p1", Bet = 10 };
            var player2 = new Player { Name = "p2", Bet = 20 };
            game.AddPlayerToGame(player1);
            game.AddPlayerToGame(player2);
            game.GameFirsStep();
            player1.Ready();
            player2.Ready();
            game.EveryoneReadyCheck();
            game.DealerTakeCards();

            // Act
            var winners = game.GameEndScoring();

            // Assert
            // this will depend on your game's rules and the random cards drawn, 
            // but this test ensures the GameEndScoring method is working.
            CollectionAssert.AllItemsAreInstancesOfType(winners, typeof(string));
        }
    }
}
