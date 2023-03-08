using OOP_ICT.Interfaces;

namespace OOP_ICT;

public class Dealer: IDealer
{
    /// <summary>
    /// Класс Дилер
    ///В конструкторе При создании нового дилера
    /// создается стоковая колода
    /// 
    /// Далее дилер может перемешать колоду
    /// с помощью метода CreateShuffledUserDeck
    /// Также колода сохраниться в класс Колоды
    ///
    /// GetCardListFromDealer
    /// для получения списка карт
    /// Его можно получить только через диллера
    ///
    /// Метод ShowCardDeck, для просмотра карт в колоде
    /// Вызывается из класса Колоды, т к с колодой можно
    /// взаимодействоать только через дилера
    /// </summary>
    
    private CardDeck _cardDeck = new CardDeck();

    public void CreateShuffledUserDeck()
    {
        var shuffled = ShuffleAlghorithm.Shuffle(_cardDeck.GetCardList);
        _cardDeck.Add(shuffled);
    }

    public IReadOnlyList<Card> GetCardListFromDealer
    {
        get { return _cardDeck.GetCardList; }
    }

    public string ShowCardDeck()
    {
        return _cardDeck.ToString();
    }
}