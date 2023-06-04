using OOP_ICT.Second.models.Player.Interfaces;

namespace OOP_ICT.Second.Models.Fabrica;

public class PlayerCreator
{
    public static IPlayer CreatePlayer(string playerType, string name)
    {
        switch (playerType)
        {
            case "BlackJack":
                return new Player(name);
            default:
                throw new ArgumentException("Invalid player type");
        }
    }
}