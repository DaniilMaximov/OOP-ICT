using OOP_ICT.Second.models.Player.Interfaces;

public class BetFactory
{
    public static IBet CreateBet(string betType, IPlayer player, int amount)
    {
        switch (betType)
        {
            case "BlackJack":
                return new Bet(player, amount);
            default:
                throw new ArgumentException("Invalid bet type");
        }
    }
}