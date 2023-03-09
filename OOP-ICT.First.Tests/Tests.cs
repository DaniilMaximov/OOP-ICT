using Xunit;
using Xunit.Sdk;

namespace OOP_ICT;

public class Tests
{
    //CardTests
    [Fact]
    public void CardConstructor_SetsRankAndSuit()
    {
        // Arrange
        var rank = CardRank.Ace;
        var suit = CardSuit.Hearts;

        // Act
        var card = new Card(rank, suit);

        // Assert
        Assert.Equal(rank, card.GetRank());
        Assert.Equal(suit, card.GetSuit());
    }

    [Fact]
    public void ToString_ReturnsRankAndSuitString()
    {
        // Arrange
        var rank = CardRank.King;
        var suit = CardSuit.Diamonds;
        var card = new Card(rank, suit);

        // Act
        var result = card.ToString();

        // Assert
        Assert.Equal($"rank - {rank} | suit - {suit}", result);
    }

    //CardDeckTests

    [Fact]
    public void CardDeckConstructor_CreatesDefaultDeck()
    {
        // Arrange & Act
        var deck = new CardDeck();

        // Assert
        Assert.Equal(52, deck.GetCardList().Count);
    }

    [Fact]
    public void AddCardList_ReplacesExistingDeck()
    {
        // Arrange
        var deck = new CardDeck();
        var newDeck = new List<Card>()
        {
            new Card(CardRank.Ace, CardSuit.Clubs),
            new Card(CardRank.Two, CardSuit.Diamonds),
            new Card(CardRank.Three, CardSuit.Hearts),
            new Card(CardRank.Four, CardSuit.Spades)
        };

        // Act
        deck.AddCardList(newDeck);

        // Assert
        Assert.Equal(newDeck, deck.GetCardList());
    }

    [Fact]
    public void ToString_ReturnsAllCardsList()
    {
        // Arrange
        var deck = new CardDeck();
        var expectedString = "______ All cards list ______\n"
                             + string.Join("\n", deck.GetCardList())
                             + "\n_____________________________";

        // Act
        var result = deck.ToString();

        // Assert
        Assert.Equal(expectedString, result);
    }

    //DealerTests

    [Fact]
    public void CreateShuffledUserDeck_ShufflesDeck()
    {
        // Arrange
        var dealer = new Dealer();
        var originalDeck = dealer.GetCardListFromDealer;

        // Act
        dealer.CreateShuffledUserDeck();
        var shuffledDeck = dealer.GetCardListFromDealer;

        // Assert
        Assert.NotEqual(originalDeck, shuffledDeck);
    }

    [Fact]
    public void GetCardListFromDealer_ReturnsCardList()
    {
        // Arrange
        var dealer = new Dealer();

        // Act
        var result = dealer.GetCardListFromDealer;

        // Assert
        Assert.Equal(52, result.Count);
        foreach (var card in result)
        {
            Assert.NotNull(card);
        }
    }

    [Fact]
    public void ShowCardDeck_ReturnsAllCardsList()
    {
        // Arrange
        var dealer = new Dealer();
        var expectedString = "______ All cards list ______\n"
                             + string.Join("\n", dealer.GetCardListFromDealer)
                             + "\n_____________________________";

        // Act
        var result = dealer.ShowCardDeck();

        // Assert
        Assert.Equal(expectedString, result);
    }
}