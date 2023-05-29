namespace OOP_ICT.Second.Extensions;

public static class ListExtensions
{
    public static T Pop<T>(this List<T> list)
    {
        var lastElem = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return lastElem;
    }
}