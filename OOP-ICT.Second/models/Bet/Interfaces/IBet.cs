using OOP_ICT.Second.Models;

public interface IBet
{
    public Player? Player { get; set; }
    public int Amount { get; set; }
}