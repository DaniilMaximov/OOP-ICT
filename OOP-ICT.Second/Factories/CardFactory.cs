using OOP_ICT.Second.Interfaces;
using OOP_ICT.Second.Models;

namespace OOP_ICT.Second.Factories;

public abstract class CardFactory
{
    public abstract ICard CreateCard(ECardRank rank, ECardSuit suit);
}

public class CardCreator : CardFactory
{
    public override ICard CreateCard(ECardRank rank, ECardSuit suit)
    {
        return new Card(rank, suit);
    }
}