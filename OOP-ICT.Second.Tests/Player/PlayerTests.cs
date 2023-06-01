using NUnit.Framework;
using OOP_ICT.Second.Models;

namespace OOP_ICT.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void CardsSum_ReturnsCorrectSumOfCards()
        {
            // Arrange
            var player = new Player();
            player.Cards.Add(new Card(ECardRank.Ace, ECardSuit.Spades));
            player.Cards.Add(new Card(ECardRank.Ten, ECardSuit.Hearts));

            // Act
            var sum = player.CardsSum();

            // Assert
            Assert.AreEqual(21, sum); // if Ace is 11 and Ten is 10
        }

        [Test]
        public void Ready_SetsPlayerReadinessToTrue()
        {
            // Arrange
            var player = new Player();

            // Act
            player.Ready();

            // Assert
            Assert.IsTrue(player.Readiness);
        }

        [Test]
        public void Player_ConstructorAssignsDefaultName()
        {
            // Arrange & Act
            var player = new Player();

            // Assert
            Assert.AreEqual("DefaultName", player.Name);
        }
    }
}