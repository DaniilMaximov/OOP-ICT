namespace OOP_ICT;

public class ShuffleAlghorithm
{
    public static List<Card> Shuffle(List<Card> cards)
    {
        int n = cards.Count / 2;
        var shuffled = new List<Card>();
        for (int i = 0; i < n; i++)
        {
            shuffled.Add(cards[i]);
            shuffled.Add(cards[i + n]);
        }

        if (cards.Count % 2 != 0)
        {
            shuffled.Add(cards[cards.Count - 1]);
        }

        return shuffled;
    }
}