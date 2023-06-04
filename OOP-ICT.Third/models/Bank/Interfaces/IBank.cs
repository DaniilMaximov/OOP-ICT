using OOP_ICT.Second.models.Player.Interfaces;
namespace OOP_ICT.Third.models.Bank.Interfaces;

// Интерфейс банковского сервиса
public interface IBank
{
    void PutMoney(IPlayer player, int amount);
    void TakeMoney(IPlayer player, int amount);
}