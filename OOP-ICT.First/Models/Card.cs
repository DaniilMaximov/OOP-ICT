namespace OOP_ICT.Models;

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

    public override string ToString()
    {
        return ($"rank - {_rank} | suit - {_suit}");
    }
}