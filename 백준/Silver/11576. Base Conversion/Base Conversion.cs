public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static string result;
    static int baseA;
    static int baseB;
    static int size;
    static int total;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        baseA = input[0];
        baseB = input[1];

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        total = 0;
        for (int i = 0; i < size; ++i)
        {
            total += input[i] * (int)(Math.Pow(baseA, size - i - 1));
        }

        result = "";
        while (total > 0)
        {
            result += $" {total % baseB}";
            total /= baseB;
        }

        int count = result.Split().Count();
        for (int i = count - 1; i >= 0; --i)
        {
            SW.Write($"{result.Split()[i]} ");
        }

        SR.Close();
        SW.Close();
    }
}