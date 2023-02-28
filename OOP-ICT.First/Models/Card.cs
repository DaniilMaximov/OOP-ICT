namespace OOP_ICT;

public enum CardRank
{
    /// <summary>
    /// enum для наименований карт
    /// </summary>
    Ace,
    King,
    Queen,
    Jack,
    Ten,
    Nine,
    Eight,
    Seven,
    Six,
    Five,
    Four,
    Three,
    Two
}

public enum CardSuit
{
    /// <summary>
    /// enum Для мастей
    /// </summary>
    Spades,
    Hearts,
    Clubs,
    Diamonds
}

public class Card
{
    /// <summary>
    /// Класс карта имеет свойства Масть и Наименование
    /// rank и suit заполняются в конструкторе
    /// Метод ShowCardInfo выовдит информацию о карте
    /// </summary>
    
    private readonly CardRank _rank;
    private readonly CardSuit _suit;

    public Card(CardRank rank, CardSuit suit)
    {
        _rank = rank;
        _suit = suit;
    }

    public string CardInfo()
    {
        return ($"rank - {_rank} | suit - {_suit}");
    }
}