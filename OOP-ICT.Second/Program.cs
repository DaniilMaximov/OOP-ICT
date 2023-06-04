using OOP_ICT.Second.Models.Fabrica;

// создаем игру + автоматом создается диллер
var game = new BlackJackGame();

// создаем играков
var player1 = PlayerCreator.CreatePlayer("BlackJack", "p1");
var player2 = PlayerCreator.CreatePlayer("BlackJack", "p2");

// присоединяем играков к игре
game.AddPlayerToGame(player1);
game.AddPlayerToGame(player2);
Console.WriteLine(game.ShowPlayers());

// игроки делают ставки
game.PlaceBet(player1, 200);
game.PlaceBet(player2, 300);

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