using OOP_ICT.Second.Interfaces;

namespace OOP_ICT.Second.Models;

public class Card : ICard
{
    public Card(ECardRank rank, ECardSuit suit)
    {
        Rank = rank;
        Suit = suit;
    }

    /// <summary>
    ///     Класс карта реализует интерфейс
    ///     карта, имеет suite и rank
    /// </summary>
    public ECardRank Rank { get; set; }

    public ECardSuit Suit { get; set; }
    
    public override string ToString()
    {
        return $"rank - {Rank} | suit - {Suit}";
    }
}