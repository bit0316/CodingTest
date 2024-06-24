public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_SIZE = 5;

    static void Main(string[] args)
    {
        int sum;
        int score;

        sum = 0;
        for (int i = 0; i < MAX_SIZE; ++i)
        {
            score = int.Parse(SR.ReadLine());
            sum += score < 40 ? 40 : score;
        }

        Console.WriteLine(sum / MAX_SIZE);

        SR.Close();
        SW.Close();
    }
}