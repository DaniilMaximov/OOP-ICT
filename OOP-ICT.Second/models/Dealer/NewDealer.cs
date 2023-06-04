using OOP_ICT.Second.Extensions;
using OOP_ICT.Second.models.Player.Interfaces;

namespace OOP_ICT;

public class NewDealer : Dealer, IPlayer
{
    public NewDealer()
    {
        Name = "Dealer";
        Cards = new List<Card>();
        CreateShuffledUserDeck();
    }

    public string Name { get; set; }
    public int Cash { get; set; }
    public List<Card> Cards { get; set; }

    public int CardsSum()
    {
        var summ = 0;
        foreach (var card in Cards) summ += (int)card.GetRank();
        return summ;
    }

    public string ShowYourCards()
    {
        var l = new List<string>();
        foreach (var card in Cards) l.Add(card.GetRank().ToString());

        return $"{Name}'s cards: " + string.Join(",", l);
    }

    public Card DrawCard()
    {
        var popped = CardDeck.GetCardList().Pop();
        CardDeck.AddCardList(CardDeck.GetCardList());
        return popped;
    }

    public override string ToString()
    {
        return $"summa - {CardsSum()}, {ShowYourCards()} ";
    }
}