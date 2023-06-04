using OOP_ICT.Second.Models;
using OOP_ICT.Second.models.Player.Interfaces;
using OOP_ICT.Third.models.Bank.Interfaces;

namespace OOP_ICT.Third.models.Casino.Abstract;

// Абстракция Казино
public abstract class AbstractCasino
{
    protected IBank Bank;

    protected AbstractCasino(IBank bank)
    {
        Bank = bank;
    }

    public abstract void GetWin(IPlayer player, int amount);
    public abstract void GetLoss(IPlayer player, int amount);
}