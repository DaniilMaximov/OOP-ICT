using OOP_ICT.Fourth.Models.PokerGame.Enums;
using OOP_ICT.Second.Models;
using OOP_ICT.Second.models.Player.Interfaces;
using OOP_ICT.Third.models.Bank;

namespace OOP_ICT.Fourth.Models.PokerGame;

/// <summary>
/// Метод для начала новой игры
///
/// Метод для раздачи карт игрокам
///
/// Метод для получения ставок от игроков
///
/// Метод для сравнения комбинаций карт у игроков и определения победителя
///
/// Метод для начисления выигрыша победителю
/// 
/// Метод для начисления проигрыша игрокам
/// </summary>

public class PokerGame
{
    
    public NewDealer PokerDealer { get; set; }
    public List<IPlayer> Players { get; }
    public List<IBet> Bets { get; private set; }
    private PokerBank Bank;
    
    public IPlayer winner { get; private set; }
    
    // конструктор
    public PokerGame()
    {
        Bank = new PokerBank();
        PokerDealer = new NewDealer
        {
            Name = "Dealer"
        };
        Bets = new List<IBet>();
        Players = new List<IPlayer>();
    }
    // Метод для начала новой игры
    public void StartNewGame()
    {
        // очищаем список победителей и ставок
        Bets = new List<IBet>();
        // выкладываются первые 3 карты 
        PokerDealer.Cards.Add(PokerDealer.DrawCard());
        PokerDealer.Cards.Add(PokerDealer.DrawCard());
        PokerDealer.Cards.Add(PokerDealer.DrawCard());
    }

    // Метод для раздачи карт игрокам
    public void DealDrawCards()
    {
        // каждому игроку раздаются по 2 карты
        foreach (var player in Players)
        {
            player.Cards.Add(PokerDealer.DrawCard());
            player.Cards.Add(PokerDealer.DrawCard());
        }
    }

    // Метод для получения ставок от игроков
    public void PlaceBet(IPlayer player, int amount)
    {
        if (player.Cash < amount)
        {
            Console.WriteLine("Insufficient funds for bet");
            return;
        }

        var bet = BetFactory.CreateBet("BlackJack", player, amount);
        player.Cash -= bet.Amount;
        Bets.Add(bet);
    }
    // Метод для сравнения комбинаций карт у игроков и определения победителя
    public Player CompareHands()
    {
        Player winner = null;
        HandRank highestRank = HandRank.HighCard;
        int highestValue = 0;

        foreach (Player player in Players)
        {
            HandRank rank = GameLogic.EvaluateHand(player.Cards);
            int value = GameLogic.HandValue(player.Cards, rank);

            if (rank > highestRank || (rank == highestRank && value > highestValue))
            {
                highestRank = rank;
                highestValue = value;
                winner = player;
            }
        }

        return winner;
    }
    
    // Метод подсчета выйгрыша

    public int CountWinAmount()
    {
        int summ = 0;
        foreach (var bet in Bets)
        {
            summ += bet.Amount;
        }

        return summ;
    }


    // Метод для начисления выигрыша победителю
    public void PayoutWinner(Player winner)
    {
        GetWin(winner, CountWinAmount());
    }
    
    // Метод для начисления проигрыша игрокам
    public void DeductLosers()
    {
        foreach (var player in Players)
        {
            int playerBet = FindBetByPlayer(player);
            GetLoss(player, playerBet);
        }
    }
    
    
    public int FindBetByPlayer(IPlayer player)
    {
        foreach (var bet in Bets)
            if (bet.Player == player)
                return bet.Amount;

        return 0;
    }
    public void GetWin(IPlayer player, int amount)
    {
        Bank.PutMoney(player, amount);
    }

    public void GetLoss(IPlayer player, int amount)
    {
        Bank.TakeMoney(player, amount);
    }

    
}