using OOP_ICT.Second.Factories;
using OOP_ICT.Second.Interfaces;

namespace OOP_ICT.Second.Models;

public class CardDeck : AbstractCardDeck
{
    private readonly CardCreator _cardCreator = new();

    /// <summary>
    ///     Класс колоды
    ///     при создании колоды, в конструкторе
    ///     с помощью DefaultDeckCreating создается новая
    ///     стоковая колода
    ///     есть публичный getter - вернет список карт
    ///     Ну и метод для вывода порядка и состава колоды
    ///     ShowCardDeck
    /// </summary>
    private List<ICard> _cardList1;

    public CardDeck()
    {
        _cardList1 = DefaultDeckCreating();
    }

    public override List<ICard> CardList
    {
        get => _cardList1;
        set => _cardList1 = value;
    }

    private List<ICard> DefaultDeckCreating()
    {
        var defaultDeck = new List<ICard>(CardsAmount);

        foreach (ECardRank rank in Enum.GetValues(typeof(ECardRank)))
        foreach (ECardSuit suit in Enum.GetValues(typeof(ECardSuit)))
            defaultDeck.Add(_cardCreator.CreateCard(rank, suit));
        return defaultDeck;
    }


    public override string ToString()
    {
        var cardsList = string.Join("\n", CardList.Select(card => card.ToString()));
        return $"______ All cards list ______\n{cardsList}\n_____________________________";
    }
}