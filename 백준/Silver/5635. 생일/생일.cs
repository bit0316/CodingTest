public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static List<(int, int, int, string)> birthday = new List<(int, int, int, string)>();
    static string[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; i++)
        {
            input = SR.ReadLine().Split();
            birthday.Add((int.Parse(input[3]), int.Parse(input[2]), int.Parse(input[1]), input[0]));
        }
        birthday.Sort();

        Console.WriteLine(birthday.Last().Item4);
        Console.WriteLine(birthday.First().Item4);

        SR.Close();
        SW.Close();
    }
}