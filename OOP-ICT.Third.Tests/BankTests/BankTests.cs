using NUnit.Framework;
using OOP_ICT.Second.Models;
using OOP_ICT.Third.models.Bank;

namespace OOP_ICT.Third.Tests.BankTests;

[TestFixture]
public class BankServiceTests
{
    private Bank _bankService;
    private Player _player;

    [SetUp]
    public void Setup()
    {
        _bankService = new Bank();
        _player = new Player("p1", 500);
    }

    [Test]
    public void Deposit_IncreasesPlayerBalance()
    {
        _bankService.PutMoney(_player, 100);

        Assert.AreEqual(600, _player.Cash);
    }

    [Test]
    public void Withdraw_DecreasesPlayerBalance()
    {
        _bankService.TakeMoney(_player, 200);

        Assert.AreEqual(300, _player.Cash);
    }
}