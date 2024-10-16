public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<(int, int)> points = new List<(int, int)> { (1, 2), (1, 3), (1, 4), (2, 3), (2, 4), (3, 4) };
    static List<int> list = new List<int> { 0, 1, 0, 0, 2 };

    static void Main(string[] args)
    {
        string input = SR.ReadLine();

        foreach (char ch in input)
        {
            (list[points[ch - 'A'].Item1], list[points[ch - 'A'].Item2]) = (list[points[ch - 'A'].Item2], list[points[ch - 'A'].Item1]);
        }
        SW.WriteLine(list.IndexOf(1));
        SW.WriteLine(list.IndexOf(2));

        SR.Close();
        SW.Close();
    }
}