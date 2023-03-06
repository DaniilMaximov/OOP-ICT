namespace OOP_ICT.Models;
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
    private const int CardsAmount = 52;

    internal CardDeck()
    {
        _cards = DefaultDeckCreating();
    }

    private List<Card> DefaultDeckCreating()
    {
        
        var defaultDeck = new List<Card>(CardsAmount);
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
        _cards.ForEach(i => Console.WriteLine(i));
        Console.WriteLine("_____________________________");
    }
}