using OOP_ICT.Second.Models;

namespace OOP_ICT.Second.Builders;

internal abstract class CommonPlayerBuilder
{
    public abstract void SetName(string name);
    public abstract void SetCash(int cash);
}