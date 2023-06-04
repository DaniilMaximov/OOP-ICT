using OOP_ICT.Second.Models.Fabrica;
using OOP_ICT.Third.models.Bank;
using OOP_ICT.Third.models.BlackjackCasino;

///
/// Реализуем паттерн мост и фабрику
///
///
///Фабрика (Factory) - это паттерн проектирования, который
/// предоставляет интерфейс для создания семейств взаимосвязанных
/// объектов без указания их конкретных классов.
///
///Мост (Bridge) - это структурный шаблон проектирования,
/// который позволяет разделять абстракцию и реализацию
/// таким образом, чтобы они могли изменяться независимо друг от друга.
///
///


// создаем игру + автоматом создается диллер
var game = new BlackJackGame();
var bank = new Bank();
var casino = new BlackjackCasino(new Bank());

// создаем играков
var player1 = PlayerCreator.CreatePlayer("BlackJack", "p1");
var player2 = PlayerCreator.CreatePlayer("BlackJack", "p2");

// присоединяем играков к игре
game.AddPlayerToGame(player1);
game.AddPlayerToGame(player2);
Console.WriteLine(game.ShowPlayers());

// игроки делают ставки

bank.CheckBalance(player1, 200);
bank.TakeMoney(player1,200);
BetFactory.CreateBet("BlackJack", player1, 200);

bank.CheckBalance(player2, 300);
bank.TakeMoney(player2,300);
BetFactory.CreateBet("BlackJack", player2, 300);


// Начинаем игру
game.GameFirsStep();

// смотрим карты и если нужно берем еще 
Console.WriteLine(player1);
Console.WriteLine(player2);

game.GetOneMoreCard(player1);
Console.WriteLine(player1.CardsSum());
game.ShowCards();

// диллер берет карты
game.DealerTakesCards();

// подсчет очков игры и нахождение победителей
//завершение игры и в случае выйгрыша
// игроку удваивают ставку
game.GameEndScoring();


Console.WriteLine(game.Dealer1);
Console.WriteLine(game.ShowWinnerList());

foreach (var winner in game.WinnerList)
{
    casino.BlackJack(player1, game.FindBetByPlayer(player1)*2);
}