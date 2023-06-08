using OOP_ICT.Second.models.Player.Interfaces;
using OOP_ICT.Third.models.Bank.Interfaces;


public class PokerBank : IBank
{
    public void PutMoney(IPlayer player, int amount)
    {
        player.Cash += amount;
    }

    public void TakeMoney(IPlayer player, int amount)
    {
        if(player.Cash >= amount)
        {
            player.Cash -= amount;
        }
        else
        {
            throw new InvalidOperationException("Операция не возможна, слишком мало средств");
        }
    }
    // Метод для проверки наличия достаточной суммы на счету игрока для ставки
    public bool CheckBalance(IPlayer player, int betAmount)
    {
        return player.Cash >= betAmount;
    }
}