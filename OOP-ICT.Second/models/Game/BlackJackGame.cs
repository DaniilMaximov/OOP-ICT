using OOP_ICT;
using OOP_ICT.Second.models.Player.Interfaces;

public class BlackJackGame
{
    public BlackJackGame()
    {
        Dealer1 = new NewDealer
        {
            Name = "Dealer"
        };
        WinnerList = new List<string>();
        Bets = new List<IBet>();
        Players = new List<IPlayer>();
    }

    public NewDealer Dealer1 { get; set; }
    public List<string> WinnerList { get; }
    public List<IPlayer> Players { get; }
    public List<IBet> Bets { get; }


    public void AddPlayerToGame(IPlayer player)
    {
        Players.Add(player);
    }

    public void GameFirsStep()
    {
        foreach (var player in Players)
        {
            player.Cards.Add(Dealer1.DrawCard());
            player.Cards.Add(Dealer1.DrawCard());
        }

        Dealer1.Cards.Add(Dealer1.DrawCard());
    }

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

    public int FindBetByPlayer(IPlayer player)
    {
        foreach (var bet in Bets)
            if (bet.Player == player)
                return bet.Amount;

        return 0;
    }

    public void GetOneMoreCard(IPlayer player)
    {
        player.Cards.Add(Dealer1.DrawCard());
    }

    public void DealerTakesCards()
    {
        while (Dealer1.CardsSum() < 17) Dealer1.Cards.Add(Dealer1.DrawCard());
        Dealer1.Cards.Add(Dealer1.DrawCard());
    }

    public List<string> GameEndScoring()
    {
        foreach (var player in Players)
            if (((Dealer1.CardsSum() > 21) & (player.CardsSum() <= 21)) |
                ((player.CardsSum() > Dealer1.CardsSum()) &
                 (player.CardsSum() <= 21) &
                 (Dealer1.CardsSum() <= 21)))
            {
                player.Cash += FindBetByPlayer(player) * 2;
                Console.WriteLine(player.Name);
                WinnerList.Add(player.Name);
            }

        Bets.Clear();
        return WinnerList;
    }

    public void ShowCards()
    {
        Console.WriteLine(Dealer1.ShowCardDeck());
    }

    public string ShowWinnerList()
    {
        return "WINNERS ARE: " + string.Join(",", WinnerList);
    }

    public string ShowPlayers()
    {
        return "players: " + string.Join(",", Players);
    }
}