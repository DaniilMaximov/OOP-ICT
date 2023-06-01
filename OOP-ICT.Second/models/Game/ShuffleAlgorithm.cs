using OOP_ICT.Second.Interfaces;

namespace OOP_ICT;

public abstract class ShuffleAlgorithm
{
    /// <summary>
    ///     алгоритм для перемешивания колоды
    ///     метод Shuggle статичный
    /// </summary>
    public static List<ICard> Shuffle(List<ICard> cards)
    {
        var n = cards.Count / 2;
        var shuffled = new List<ICard>();
        for (var i = 0; i < n; i++)
        {
            shuffled.Add(cards[i]);
            shuffled.Add(cards[i + n]);
        }

        if (cards.Count % 2 != 0) shuffled.Add(cards[^1]);

        return shuffled;
    }
}