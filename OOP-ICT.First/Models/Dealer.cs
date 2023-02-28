using OOP_ICT;
using OOP_ICT.Interfaces;
using OOP_ICT.Deckaccess;

public class Dealer : IDealer
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

    
    private CardDeck _cardDeck;

    public void InitializeCardDeck()
    {
        _cardDeck = new CardDeck();
    }

    public void CreateShuffledUserDeck()
    {
        int n = _cardDeck.GetCardList.Count / 2;
        var shuffled = new List<Card>();
        for (int i = 0; i < n; i++)
        {
            shuffled.Add(_cardDeck.GetCardList[i]);
            shuffled.Add(_cardDeck.GetCardList[i + n]);
        }

        if (_cardDeck.GetCardList.Count % 2 != 0)
        {
            shuffled.Add(_cardDeck.GetCardList[_cardDeck.GetCardList.Count - 1]);
        }

        _cardDeck.GetCardList = shuffled;
    }

    public List<Card> GetCardListFromDealer
    {
        get { return _cardDeck.GetCardList; }
    }

    public void ShowCardDeck()
    {
        _cardDeck.ShowCardDeck();
    }
}