using OOP_ICT;
using OOP_ICT.Second.Models;

// создаем игру + автоматом создается диллер
var game = new BlackJackGame();

// создаем играков
var player1 = new Player();
player1.Name = "p1";
var player2 = new Player();
player2.Name = "p2";

// присоединяем играков к игре
game.AddPlayerToGame(player1);
game.AddPlayerToGame(player2);

game.ShowPlayers();

// игроки делают ставки
player1.Bet = 200;
player2.Bet = 300;

// проверяем что все игроки сделали ставки
game.MakingBetsCheck();

// начинаем игру - раздаем игрокам и диллеру карты
game.GameFirsStep();

// смотрим карты и если нужно берем еще 
game.ShowCards();

Console.WriteLine(player1.CardsSum());
Console.WriteLine(player2.CardsSum());

game.GetOneMoreCard(player1);
Console.WriteLine(player1.CardsSum());

// обозначаем что все игроки сделали ход
player1.Ready();
player2.Ready();

// проверяем готовность играков
game.EveryoneReadyCheck();

// диллер берет карты
game.DealerTakeCards();

// подсчет очков игры и нахождение победителей
Console.WriteLine(game.GameEndScoring());





