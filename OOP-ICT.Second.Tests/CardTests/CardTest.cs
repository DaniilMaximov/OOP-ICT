using NUnit.Framework;

namespace OOP_ICT.Second.Models.Tests;

[TestFixture]
public class CardTests
{
    [Test]
    public void Card_InitializesWithGivenRankAndSuit()
    {
        // Arrange
        var rank = CardRank.King;
        var suit = CardSuit.Hearts;

        // Act
        var card = new Card(rank, suit);

        // Assert
        Assert.AreEqual(rank, card.GetRank());
        Assert.AreEqual(suit, card.GetSuit());
    }

    [Test]
    public void ToString_ReturnsExpectedString()
    {
        // Arrange
        var rank = CardRank.Queen;
        var suit = CardSuit.Clubs;
        var expectedString = $"rank - {rank} | suit - {suit}";

        // Act
        var card = new Card(rank, suit);
        var resultString = card.ToString();

        // Assert
        Assert.AreEqual(expectedString, resultString);
    }
}