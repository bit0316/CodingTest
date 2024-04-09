public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int money;
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        money = input[1];

        result = GetCoinCount(size, money);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetCoinCount(int size, int money)
    {
        int[] coins = new int[size];
        int count = 0;

        for (int i = 0; i < size; ++i)
        {
            coins[i] = int.Parse(SR.ReadLine());
        }

        for (int i = size - 1; i >= 0; --i)
        {
            while (money >= coins[i])
            {
                money -= coins[i];
                count++;
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}