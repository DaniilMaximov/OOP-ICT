using Moq;
using NUnit.Framework;
using OOP_ICT.Second.models.Player.Interfaces;
using Xunit;

public class PokerBankTests
{
    [Fact]
    public void PutMoney_ShouldIncreasePlayerCash()
    {
        var playerMock = new Mock<IPlayer>();
        playerMock.SetupProperty(player => player.Cash, 100);

        var pokerBank = new PokerBank();

        pokerBank.PutMoney(playerMock.Object, 50);

        Assert.AreEqual(150, playerMock.Object.Cash);
    }

    [Fact]
    public void TakeMoney_ShouldDecreasePlayerCash()
    {
        var playerMock = new Mock<IPlayer>();
        playerMock.SetupProperty(player => player.Cash, 100);

        var pokerBank = new PokerBank();

        pokerBank.TakeMoney(playerMock.Object, 50);

        Assert.AreEqual(50, playerMock.Object.Cash);
    }

    [Fact]
    public void TakeMoney_ShouldThrowException_WhenInsufficientFunds()
    {
        var playerMock = new Mock<IPlayer>();
        playerMock.SetupProperty(player => player.Cash, 40);

        var pokerBank = new PokerBank();

        Assert.Throws<InvalidOperationException>(() => pokerBank.TakeMoney(playerMock.Object, 50));
    }

    [Xunit.Theory]
    [InlineData(100, 50, true)]
    [InlineData(50, 100, false)]
    public void CheckBalance_ShouldReturnExpectedResult(int initialCash, int betAmount, bool expectedResult)
    {
        var playerMock = new Mock<IPlayer>();
        playerMock.Setup(player => player.Cash).Returns(initialCash);

        var pokerBank = new PokerBank();

        bool result = pokerBank.CheckBalance(playerMock.Object, betAmount);

        Assert.AreEqual(expectedResult, result);
    }
}