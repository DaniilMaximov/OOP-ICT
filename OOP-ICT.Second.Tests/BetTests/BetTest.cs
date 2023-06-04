using NUnit.Framework;
using OOP_ICT.Second.Models;

[TestFixture]
public class BetTests
{
    [Test]
    public void BetConstructor_CreatesBet()
    {
        // Arrange
        Player player = new Player("John", 500);

        // Act
        Bet bet = new Bet(player, 100);

        // Assert
        Assert.AreEqual(player, bet.Player);
        Assert.AreEqual(100, bet.Amount);
    }
    
}