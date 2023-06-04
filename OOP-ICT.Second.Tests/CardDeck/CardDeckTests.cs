using NUnit.Framework;

namespace OOP_ICT.Second.Models.Tests;

[TestFixture]
public class CardDeckTests
{
    [Test]
    public void CardDeck_InitializesWithDefaultDeck()
    {
        // Act
        var deck = new CardDeck();

        // Assert
        Assert.AreEqual(52, deck.GetCardList().Count);
    }

    [Test]
    public void CardDeck_CanBeAssignedNewCardList()
    {
        // Arrange
        var deck = new CardDeck();
        var newCardList = new List<Card>
        {
            new(CardRank.Ace, CardSuit.Hearts),
            new(CardRank.King, CardSuit.Spades)
        };

        // Act
        deck.AddCardList(newCardList);

        // Assert
        Assert.AreEqual(2, deck.GetCardList().Count);
    }

    [Test]
    public void ToString_ReturnsExpectedString()
    {
        // Arrange
        var deck = new CardDeck();
        var expectedString = string.Join("\n", deck.GetCardList().Select(card => card.ToString()));
        expectedString = $"______ All cards list ______\n{expectedString}\n_____________________________";

        // Act
        var resultString = deck.ToString();

        // Assert
        Assert.AreEqual(expectedString, resultString);
    }
}