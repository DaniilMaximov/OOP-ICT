using OOP_ICT.Second.Extensions;
using OOP_ICT.Second.Interfaces;
using OOP_ICT.Second.Models;

namespace OOP_ICT;

public class Dealer : Player
{
    /// <summary>
    ///     Класс Дилер
    ///     В конструкторе При создании нового дилера
    ///     создается стоковая колода
    ///     Далее дилер может перемешать колоду
    ///     с помощью метода CreateShuffledUserDeck
    ///     GetCardListFromDealer
    ///     для получения списка карт
    ///     Его можно получить только через диллера
    ///     Метод ShowCardDeck, для просмотра карт в колоде
    ///     Вызывается из класса Колоды
    /// </summary>
    private readonly CardDeck _cardDeck = new();

    public IReadOnlyList<ICard> GetCardListFromDealer => _cardDeck.CardList;


    public void CreateShuffledUserDeck()
    {
        var shuffled = ShuffleAlgorithm.Shuffle(_cardDeck.CardList);
        _cardDeck.CardList = shuffled;
    }


    public ICard DrawCard()
    {
        return _cardDeck.CardList.Pop();
    }

    public string ShowCardDeck()
    {
        return _cardDeck.ToString();
    }
}