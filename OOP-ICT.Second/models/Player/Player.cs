using OOP_ICT.Second.Interfaces;

namespace OOP_ICT.Second.Models;

public class Player
{
    public int Bet;

    public int Cash;

    public string Name { get; set; }

    public bool Readiness = false;

    public Player()
    {
        Name = "DefaultName";
        Cards = new List<ICard>();
    }

    public List<ICard> Cards { get; set; }

    public int CardsSum()
    {
        var summ = 0;
        foreach (var card in Cards) summ += (int)card.Rank;

        return summ;
    }

    public void Ready()
    {
        Readiness = true;
    }
}