using NUnit.Framework;
using OOP_ICT.Second.Models;

namespace OOP_ICT.Tests;

[TestFixture]
public class BlackJackGameTests
{
    [Test]
    public void AddPlayerToGame_AddsPlayerToGame()
    {
        // Arrange
        var game = new BlackJackGame();
        var player = new Player("p1");

        // Act
        game.AddPlayerToGame(player);

        // Assert
        Assert.Contains(player, game.Players);
    }

    [Test]
    public void GameFirstStep_GivesPlayersTwoCards()
    {
        // Arrange
        var game = new BlackJackGame();
        var player = new Player("p1");
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
        var player = new Player("test");
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
        game.DealerTakesCards();

        // Assert
        Assert.GreaterOrEqual(game.Dealer1.CardsSum(), 17);
    }
}