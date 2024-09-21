public class Program
{
    static Dictionary<string, string> clubs = new Dictionary<string, string>
    {
        { "M", "MatKor" }, { "W", "WiCys" }, { "C", "CyKor" }, { "A", "AlKor" }, { "$", "$clear" }
    };

    static void Main(string[] args)
    {
        Console.WriteLine(clubs[Console.ReadLine()]);
    }
}