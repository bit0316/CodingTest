public class Program
{
    static Dictionary<string, int> score = new Dictionary<string, int>
    {
        { "miss", 0 }, { "bad", 200 }, { "cool", 400 }, { "great", 600 }, { "perfect", 1000 }
    };

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        Console.WriteLine(int.Parse(input[0]) * score[input[1]]);
    }
}