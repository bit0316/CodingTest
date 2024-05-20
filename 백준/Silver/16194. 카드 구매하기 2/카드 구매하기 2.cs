public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] prices;
    static int[] totals;
    static int[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        prices = new int[size + 1];
        totals = new int[size + 1];

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        for (int i = 1; i <= size; ++i)
        {
            prices[i] = input[i - 1];
        }

        for (int i = 1; i <= size; ++i)
        {
            totals[i] = totals[i - 1] + prices[i];
            for (int j = 1; j <= i; ++j)
            {
                totals[i] = Math.Min(totals[i], totals[i - j] + prices[j]);
            }
        }
        SW.WriteLine(totals[size]);

        SR.Close();
        SW.Close();
    }
}