using OOP_ICT.Second.Models;
using OOP_ICT.Second.models.Player.Interfaces;

public class Bet : IBet
{
    public Bet(IPlayer player, int amount)
    {
        Player = (Player?)player;
        Amount = amount;
    }

    public Player? Player { get; set; }
    public int Amount { get; set; }
}