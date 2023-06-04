using Moq;
using NUnit.Framework;
using OOP_ICT.Second.Models;
using OOP_ICT.Third.models.Bank.Interfaces;
using OOP_ICT.Third.models.BlackjackCasino;

namespace OOP_ICT.Third.Tests.CasinoTests;

[TestFixture]
public class CasinoTests
{
    private Mock<IBank> _bankServiceMock;
    private Player _player;

    [SetUp]
    public void Setup()
    {
        _bankServiceMock = new Mock<IBank>();
        _player = new Player("p1");
    }

    [Test]
    public void HandleWin_CallsDepositOnBankService()
    {
        var casino = new BlackjackCasino(_bankServiceMock.Object);
        casino.GetWin(_player, 100);

        _bankServiceMock.Verify(b => b.PutMoney(_player, 100), Times.Once);
    }

    [Test]
    public void HandleLoss_CallsWithdrawOnBankService()
    {
        var casino = new BlackjackCasino(_bankServiceMock.Object);
        casino.GetLoss(_player, 100);

        _bankServiceMock.Verify(b => b.TakeMoney(_player, 100), Times.Once);
    }
}