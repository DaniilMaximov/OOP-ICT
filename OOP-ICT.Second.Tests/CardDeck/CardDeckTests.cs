using NUnit.Framework;
using OOP_ICT.Second.Models;
using OOP_ICT.Second.Interfaces;
using System.Linq;

namespace OOP_ICT.Second.Models.Tests
{
    [TestFixture]
    public class CardDeckTests
    {
        [Test]
        public void CardDeck_InitializesWithDefaultDeck()
        {
            // Act
            var deck = new CardDeck();

            // Assert
            Assert.AreEqual(52, deck.CardList.Count);
        }

        [Test]
        public void CardDeck_CanBeAssignedNewCardList()
        {
            // Arrange
            var deck = new CardDeck();
            var newCardList = new List<ICard>
            {
                new Card(ECardRank.Ace, ECardSuit.Hearts),
                new Card(ECardRank.King, ECardSuit.Spades)
            };

            // Act
            deck.CardList = newCardList;

            // Assert
            Assert.AreEqual(2, deck.CardList.Count);
        }

        [Test]
        public void ToString_ReturnsExpectedString()
        {
            // Arrange
            var deck = new CardDeck();
            var expectedString = string.Join("\n", deck.CardList.Select(card => card.ToString()));
            expectedString = $"______ All cards list ______\n{expectedString}\n_____________________________";

            // Act
            var resultString = deck.ToString();

            // Assert
            Assert.AreEqual(expectedString, resultString);
        }
    }
}