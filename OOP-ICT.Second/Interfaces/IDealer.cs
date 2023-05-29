namespace OOP_ICT.Second.Interfaces;

public interface IDealer
{
    public IReadOnlyList<ICard> CardDeck { get; }

    public void ShowCardDeck();
    public void CreateShuffledUserDeck();
}