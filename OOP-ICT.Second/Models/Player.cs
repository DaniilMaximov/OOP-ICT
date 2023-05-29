using OOP_ICT.Second.Interfaces;

namespace OOP_ICT.Second.Models;

public class Player
{
    public List<ICard> Cards;

    public int Cash;

    public string? Name;
    
    public int CardsSum()
    {
        int summ = 0;
        foreach (var card in Cards)
        {
            summ += (int)card.Rank;
        }

        return summ;
    }

    public Player()
    {
        Cards = new List<ICard>();
    }

    private void test()
    {
        Name = "";
    }
}