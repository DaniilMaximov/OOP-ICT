﻿namespace OOP_ICT;

public class ShuffleAlghorithm
{
    /// <summary>
    ///     алгоритм для перемешивания колоды
    ///     метод Shuggle статичный
    /// </summary>
    public static List<Card> Shuffle(List<Card> cards)
    {
        var n = cards.Count / 2;
        var shuffled = new List<Card>();
        for (var i = 0; i < n; i++)
        {
            shuffled.Add(cards[i]);
            shuffled.Add(cards[i + n]);
        }

        if (cards.Count % 2 != 0) shuffled.Add(cards[cards.Count - 1]);

        return shuffled;
    }
}