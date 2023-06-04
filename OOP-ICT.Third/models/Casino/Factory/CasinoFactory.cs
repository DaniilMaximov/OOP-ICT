using OOP_ICT.Third.models.Bank.Interfaces;
using OOP_ICT.Third.models.Casino.Abstract;

namespace OOP_ICT.Third.models.BlackjackCasino.Fabrica;

// Фабрика Казино
public static class CasinoFactory
{
    public static AbstractCasino CreateCasino(IBank bank)
    {
        return new BlackjackCasino(bank);
    }
}