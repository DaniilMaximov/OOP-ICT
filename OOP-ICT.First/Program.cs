using OOP_ICT.Models;

public class Program
{
    public static void Main()
    {
        // Примеры использования
        var card1 = new Card(0,0);
        Console.WriteLine(card1.CardInfo());

        // проверка на доступ к колоде (ошибка доступа)
        // var cardDeck1 = new CardDeck();
        // cardDeck1.ShowCardDeck();

        // Пример создания дилера, создание колоды, перемешевание
        var dealer1 = new Dealer();
        dealer1.InitializeCardDeck();
        dealer1.ShowCardDeck();
        dealer1.CreateShuffledUserDeck();
        dealer1.ShowCardDeck();

        // проверка на получение правильного списка по запросу
        var carDeck1 = dealer1.GetCardListFromDealer;
        Console.WriteLine(carDeck1);
        carDeck1.ForEach(i => Console.WriteLine(i.CardInfo()));
    }
}
