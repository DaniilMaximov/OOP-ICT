namespace OOP_ICT.Second.Interfaces;

public interface ICard
{
    ECardRank Rank { get; set; }

    ECardSuit Suit { get; set; }
}