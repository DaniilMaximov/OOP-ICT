namespace OOP_ICT;

public class Program
{
    public static void Main()
    {
        // Примеры использования
        var card1 = new Card(0,0);
        Console.WriteLine(card1);
        
        var cardDeck1 = new CardDeck();
        Console.WriteLine(cardDeck1);

        // Пример создания дилера, создание колоды, перемешевание
        var dealer1 = new Dealer();
        Console.WriteLine("default_____________");
        Console.WriteLine(dealer1.ShowCardDeck());
        dealer1.CreateShuffledUserDeck();
        Console.WriteLine("shuffled______________");
        Console.WriteLine(dealer1.ShowCardDeck());

        // проверка на получение правильного списка по запросу
        var carDeck1 = dealer1.GetCardListFromDealer;
        // Console.WriteLine(carDeck1);
        // carDeck1.ForEach(i => Console.WriteLine(i));
    }
}
