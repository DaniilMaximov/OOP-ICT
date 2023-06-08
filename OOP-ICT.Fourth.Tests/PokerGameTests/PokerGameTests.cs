
using Moq;
using NUnit.Framework;
using OOP_ICT.Second.models.Player.Interfaces;
using Xunit;

namespace PokerGameTests
{
    public class PokerBankTests
    {
        [Fact]
        public void PutMoney_ShouldIncreasePlayerCash()
        {
            var playerMock = new Mock<IPlayer>();
            playerMock.SetupProperty(player => player.Cash, 100);

            var pokerBank = new PokerBank();

            pokerBank.PutMoney(playerMock.Object, 50);

            playerMock.VerifySet(player => player.Cash = 150);
        }

        [Fact]
        public void TakeMoney_ShouldDecreasePlayerCash()
        {
            var playerMock = new Mock<IPlayer>();
            playerMock.SetupProperty(player => player.Cash, 100);

            var pokerBank = new PokerBank();

            pokerBank.TakeMoney(playerMock.Object, 50);

            playerMock.VerifySet(player => player.Cash = 50);
        }

        [Fact]
        public void TakeMoney_ShouldThrowException_WhenNotEnoughCash()
        {
            var playerMock = new Mock<IPlayer>();
            playerMock.SetupProperty(player => player.Cash, 40);

            var pokerBank = new PokerBank();

            Assert.Throws<InvalidOperationException>(() => pokerBank.TakeMoney(playerMock.Object, 50));
        }

        [NUnit.Framework.Theory]
        [InlineData(100, 50, true)]
        [InlineData(50, 100, false)]
        public void CheckBalance_ShouldReturnExpectedResult(int cash, int bet, bool expectedResult)
        {
            var playerMock = new Mock<IPlayer>();
            playerMock.SetupGet(player => player.Cash).Returns(cash);

            var pokerBank = new PokerBank();

            bool result = pokerBank.CheckBalance(playerMock.Object, bet);

            Assert.AreEqual(expectedResult, result);
        }
    }
}