﻿using OOP_ICT.Second.models.Player.Interfaces;

namespace OOP_ICT.Second.Models;

public class Player : IPlayer
{
    public Player(string name, int startingCash = 500)
    {
        Name = name;
        Cards = new List<Card>();
        Cash = startingCash;
    }

    public int Cash { get; set; }
    public string Name { get; set; }

    public List<Card> Cards { get; set; }

    public int CardsSum()
    {
        var summ = 0;
        foreach (var card in Cards) summ += (int)card.GetRank();

        return summ;
    }


    public string ShowYourCards()
    {
        var l = new List<string>();
        foreach (var card in Cards) l.Add(card.GetRank().ToString());
        return $"{Name}'s cards: " + string.Join(",", l);
    }

    public override string ToString()
    {
        return $"summa - {CardsSum()}, {ShowYourCards()} ";
    }
}