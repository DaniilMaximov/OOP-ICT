using OOP_ICT.Interfaces;

namespace OOP_ICT;

public class Dealer : IDealer
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
    protected readonly CardDeck CardDeck = new();

    public IReadOnlyList<Card> GetCardListFromDealer => CardDeck.GetCardList();


    public void CreateShuffledUserDeck()
    {
        var shuffled = ShuffleAlghorithm.Shuffle(CardDeck.GetCardList());
        CardDeck.AddCardList(shuffled);
    }

    public string ShowCardDeck()
    {
        return CardDeck.ToString();
    }
}