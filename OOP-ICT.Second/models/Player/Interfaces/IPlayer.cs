namespace OOP_ICT.Second.models.Player.Interfaces;

public interface IPlayer
{
    public string Name { get; set; }

    public int Cash { get; set; }


    public List<Card> Cards { get; set; }

    public int CardsSum();

    public string ShowYourCards();
}