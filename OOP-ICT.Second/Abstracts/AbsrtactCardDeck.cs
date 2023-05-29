namespace OOP_ICT.Second.Interfaces;

public abstract class AbstractCardDeck
{
    protected int CardsAmount = 52;
    public abstract List<ICard> CardList { get; set; }
}