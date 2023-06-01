using NUnit.Framework;
using OOP_ICT.Second.Models;
using OOP_ICT.Second.Interfaces;

namespace OOP_ICT.Second.Models.Tests
{
    [TestFixture]
    public class CardTests
    {
        [Test]
        public void Card_InitializesWithGivenRankAndSuit()
        {
            // Arrange
            var rank = ECardRank.King;
            var suit = ECardSuit.Hearts;

            // Act
            var card = new Card(rank, suit);

            // Assert
            Assert.AreEqual(rank, card.Rank);
            Assert.AreEqual(suit, card.Suit);
        }

        [Test]
        public void ToString_ReturnsExpectedString()
        {
            // Arrange
            var rank = ECardRank.Queen;
            var suit = ECardSuit.Clubs;
            var expectedString = $"rank - {rank} | suit - {suit}";

            // Act
            var card = new Card(rank, suit);
            var resultString = card.ToString();

            // Assert
            Assert.AreEqual(expectedString, resultString);
        }
    }
}