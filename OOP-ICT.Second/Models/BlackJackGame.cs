namespace OOP_ICT.Second.Models;

internal class BlackJackGame
{
    public Dealer Dealer1 = new();
    public List<Player> players = new();
    public int playersAmount;

    private BlackJackGame(int playersAmount = 2)
    {
        this.playersAmount = playersAmount;
        InitializePlayers();
    }

    public void InitializePlayers()
    {
        var players = new List<Player>(playersAmount);
        for (var i = 0; i < playersAmount; i++)
            players.Add(new Player());
    }

    public void GameFirsStep()
    {
        foreach (var player in players)
        {
            // каждому игроку раздаются две карты
            player.Cards.Add(Dealer1.DrawCard());
            player.Cards.Add(Dealer1.DrawCard());
        }

        Dealer1.Cards.Add(Dealer1.DrawCard());
    }
    

    public void GameStep()
    {
        if (GameOverDealerCheck() & GameDealerStepCheck())
        {
            foreach (var player in players)
            {
                {
                    if (GamePlayerStepCheck(player))
                    {
                        player.Cards.Add(Dealer1.DrawCard());
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }

        Dealer1.DrawCard();

    }

    public Boolean GamePlayerStepCheck(Player player)
    {
        return player.CardsSum() > 21;
    }

    public Boolean GameDealerStepCheck()
    {
        return Dealer1.CardsSum() > 16;
    }

    public Boolean GameOverDealerCheck()
    {
        return Dealer1.CardsSum() < 22;
    }
    
}