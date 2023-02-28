namespace OOP_ICT.Deckaccess;

public class CardDeck
{
    /// <summary>
    /// Класс колоды
    /// при создании колоды, в конструкторе
    /// с помощью DefaultDeckCreating создается новая
    /// стоковая колода
    /// 
    /// есть публичный getter - вернет список карт
    ///
    /// и internal setter, чтобы кода Дилер перемешает колоду
    /// можно было обновить колоду изменениями
    ///
    /// Ну и метод для вывода порядка и состава колоды
    /// ShowCardDeck
    /// </summary>
    
    private List<Card> _cards;

    internal CardDeck()
    {
        _cards = DefaultDeckCreating();
    }

    private List<Card> DefaultDeckCreating() //Создание не размешанной колоды.
    {
        const int cardsAmount = 52;
        var defaultDeck = new List<Card>(cardsAmount);
        foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                defaultDeck.Add(new Card(rank, suit));
            }
        }

        return defaultDeck;
    }


    public List<Card> GetCardList
    {
        get { return _cards; }
        internal set { _cards = value; }
    }


    public void ShowCardDeck()
    {
        Console.WriteLine("______ All cards list ______");
        _cards.ForEach(i => Console.WriteLine(i.CardInfo()));
        Console.WriteLine("_____________________________");
    }
}