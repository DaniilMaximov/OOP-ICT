using System.Globalization;

namespace OOP_ICT.Second.Models;

public class BlackJackGame
{
    public readonly Dealer _dealer1 = new();
    public List<Player> players = new();
    public readonly List<string> winnerList = new();

    public BlackJackGame()
    {
        _dealer1.Name = "Dealer";
    }

    public object Players { get; set; }

    // 1. создаем играков с помощью New
    // 2. затем создаем список играков
    // присоединяем соданных игроков с помощью метода
    // Диллер создает и мешает колоду.
    // каждый игрок делает ставку (присваевает значению Bet сумму).
    // 3. Диллер раздает  по 2 каждому играку в списке и одну себе
    // 4. чтобы перейти на след шаг иргры все игроки дожны подтве-
    // дить что они либо взяли карту либо остались при своих
    // 5. Диллер начинает брать карты на автомате, пока у него не будет больше 17
    // как только больше 17 то стоп. Если больше 21 сразу проигрышь
    // 6. Подсчет очков и сравнение с диллером. 
    // 7. Работа со ставками.

    public void ShowCards()
    {
        Console.WriteLine(_dealer1.ShowCardDeck());
    }


    public void AddPlayerToGame(Player player)
    {
        players.Add(player);
    }

    public void GameFirsStep()
    {
        foreach (var player in players)
        {
            // каждому игроку раздаются две карты
            player.Cards.Add(_dealer1.DrawCard());
            player.Cards.Add(_dealer1.DrawCard());
        }

        _dealer1.Cards.Add(_dealer1.DrawCard());
    }

    public bool MakingBetsCheck()
    {
        foreach (var player in players)
        {
            if (player.Bet <= 0) return false;
            ;
        }

        return true;
    }

    public Boolean EveryoneReadyCheck()
    {
        foreach (var player in players)
            if (player.Readiness == false)
                return false;

        return true;
    }

    public void GetOneMoreCard(Player player)
    {
        player.Cards.Add(_dealer1.DrawCard());
    }

    public void DealerTakeCards()
    {
        while (_dealer1.CardsSum() < 17) _dealer1.Cards.Add(_dealer1.DrawCard());
        _dealer1.Cards.Add(_dealer1.DrawCard());
    }

    public List<string> GameEndScoring()
    {
        foreach (var player in players)
            if (((_dealer1.CardsSum() > 21) & (player.CardsSum() <= 21)) |
                ((player.CardsSum() > _dealer1.CardsSum()) &
                 (player.CardsSum() <= 21) &
                 (_dealer1.CardsSum() <= 21)))
            {
                player.Bet *= 2;
                Console.WriteLine(player.Name);
                winnerList.Add(player.Name);
            }
            else
            {
                player.Bet = 0;
            }

        return winnerList;
    }

    public void ShowPlayers()
    {
        foreach (var p in players)
        {
            Console.WriteLine(p.Name);
        }
    }
    
}