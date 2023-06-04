using NUnit.Framework;
using OOP_ICT.Second.Models;

namespace OOP_ICT.Tests;

[TestFixture]
public class PlayerTests
{
    [Test]
    public void CardsSum_ReturnsCorrectSumOfCards()
    {
        // Arrange
        var player = new Player("p1");
        player.Cards.Add(new Card(CardRank.Ace, CardSuit.Spades));
        player.Cards.Add(new Card(CardRank.Ten, CardSuit.Hearts));

        // Act
        var sum = player.CardsSum();

        // Assert
        Assert.AreEqual(21, sum); // if Ace is 11 and Ten is 10
    }

    [Test]
    public void Player_ConstructorAssignsDefaultName()
    {
        // Arrange & Act
        var player = new Player("p1");

        // Assert
        Assert.AreEqual("p1", player.Name);
    }
}