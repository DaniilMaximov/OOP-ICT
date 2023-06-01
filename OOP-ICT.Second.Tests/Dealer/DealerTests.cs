using NUnit.Framework;
using OOP_ICT;
using OOP_ICT.Second.Models;
using System.Collections.Generic;
using System.Linq;

namespace OOP_ICT.Tests
{
    [TestFixture]
    public class DealerTests
    {
        [Test]
        public void Dealer_InitializesWithShuffledDeck()
        {
            // Act
            var dealer = new Dealer();

            // Assert
            Assert.AreEqual(52, dealer.GetCardListFromDealer.Count);
        }

        [Test]
        public void DrawCard_RemovesCardFromDeck()
        {
            // Arrange
            var dealer = new Dealer();

            // Act
            var card = dealer.DrawCard();

            // Assert
            Assert.IsNotNull(card);
            Assert.AreEqual(51, dealer.GetCardListFromDealer.Count);
        }

        [Test]
        public void ShowCardDeck_ReturnsExpectedString()
        {
            // Arrange
            var dealer = new Dealer();
            var expectedString = string.Join("\n", dealer.GetCardListFromDealer.Select(card => card.ToString()));
            expectedString = $"______ All cards list ______\n{expectedString}\n_____________________________";

            // Act
            var resultString = dealer.ShowCardDeck();

            // Assert
            Assert.AreEqual(expectedString, resultString);
        }
    }
}