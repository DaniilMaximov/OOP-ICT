using OOP_ICT.Second.Models;
using OOP_ICT.Second.models.Player.Interfaces;
using OOP_ICT.Third.models.Bank.Interfaces;
using OOP_ICT.Third.models.Casino.Abstract;

namespace OOP_ICT.Third.models.BlackjackCasino;

// Реализация Казино
public class BlackjackCasino : AbstractCasino
{
    public BlackjackCasino(IBank bank) : base(bank)
    {
    }

    public override void GetWin(IPlayer player, int amount)
    {
        Bank.PutMoney(player, amount);
    }

    public override void GetLoss(IPlayer player, int amount)
    {
        Bank.TakeMoney(player, amount);
    }

    public void BlackJack(IPlayer player, int amount)
    {
        GetWin(player, amount * 2);
    }
}