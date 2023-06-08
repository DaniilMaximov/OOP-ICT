using OOP_ICT.Fourth.Models.PokerGame.Enums;

namespace OOP_ICT.Fourth.Models.PokerGame;

public static class GameLogic
{
   public static HandRank EvaluateHand(List<Card> hand)
    {
        bool isFlush = IsFlush(hand);
        bool isStraight = IsStraight(hand);
        int[] rankHistogram = RankHistogram(hand);

        if (isFlush && isStraight && hand.Any(card => card.GetRank() == CardRank.Ace))
        {
            return HandRank.RoyalFlush;
        }
        if (isFlush && isStraight)
        {
            return HandRank.StraightFlush;
        }
        if (rankHistogram.Max() == 4)
        {
            return HandRank.FourOfAKind;
        }
        if (rankHistogram.Any(count => count == 3) && rankHistogram.Any(count => count == 2))
        {
            return HandRank.FullHouse;
        }
        if (isFlush)
        {
            return HandRank.Flush;
        }
        if (isStraight)
        {
            return HandRank.Straight;
        }
        if (rankHistogram.Max() == 3)
        {
            return HandRank.ThreeOfAKind;
        }
        if (rankHistogram.Count(count => count == 2) == 2)
        {
            return HandRank.TwoPair;
        }
        if (rankHistogram.Any(count => count == 2))
        {
            return HandRank.Pair;
        }
        return HandRank.HighCard;
    }
    
   public static int HandValue(List<Card> hand, HandRank rank)
    {
        int[] rankHistogram = RankHistogram(hand);
        int primaryValue = 0, secondaryValue = 0;

        switch (rank)
        {
            case HandRank.FourOfAKind:
                primaryValue = rankHistogram.ToList().IndexOf(4) + 2;
                break;
            case HandRank.FullHouse:
                primaryValue = rankHistogram.ToList().IndexOf(3) + 2;
                break;
            case HandRank.ThreeOfAKind:
                primaryValue = rankHistogram.ToList().IndexOf(3) + 2;
                break;
            case HandRank.TwoPair:
                primaryValue = rankHistogram.ToList().LastIndexOf(2) + 2;
                secondaryValue = rankHistogram.ToList().IndexOf(2) + 2;
                break;
            case HandRank.Pair:
                primaryValue = rankHistogram.ToList().IndexOf(2) + 2;
                break;
            case HandRank.Straight:
            case HandRank.StraightFlush:
                primaryValue = hand.Max(card => (int)card.GetRank());
                break;
            case HandRank.Flush:
            case HandRank.HighCard:
                primaryValue = hand.Max(card => (int)card.GetRank());
                break;
        }

        return primaryValue * 15 + secondaryValue;
    }

   public static bool IsFlush(List<Card> hand)
    {
        return hand.All(card => card.GetSuit() == hand[0].GetSuit());
    }

   public static bool IsStraight(List<Card> hand)
    {
        var orderedRanks = hand.OrderBy(card => card.GetRank()).Select(card => (int)card.GetRank()).ToList();
        return orderedRanks.Zip(orderedRanks.Skip(1), (a, b) => (a + 1) == b).All(x => x);
    }

   public static int[] RankHistogram(List<Card> hand)
    {
        int[] histogram = new int[13];
        foreach (var card in hand)
        {
            histogram[(int)card.GetRank() - 2]++;
        }
        return histogram;
    } 
}