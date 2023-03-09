namespace OOP_ICT;
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
    ///
    /// Ну и метод для вывода порядка и состава колоды
    /// ShowCardDeck
    /// </summary>
    
    private List<Card> _cards;
    private const int CardsAmount = 52;

    public CardDeck()
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


    public List<Card> GetCardList() =>  _cards;
    
    public void AddCardList(List<Card> cards)
    {
        _cards = cards;
    }
    
    public override string ToString()
    {
        string cardsList = string.Join("\n", _cards.Select(card => card.ToString()));
        return $"______ All cards list ______\n{cardsList}\n_____________________________";
    }

}