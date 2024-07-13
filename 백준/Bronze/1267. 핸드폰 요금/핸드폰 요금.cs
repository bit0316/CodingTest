public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int TIME_A = 30;
    static int TIME_B = 60;
    static int MONEY_A = 10;
    static int MONEY_B = 15;

    static int size;
    static int[] arr;

    static void Main(string[] args)
    {
        int costA;
        int costB;

        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        costA = GetResult(TIME_A, MONEY_A);
        costB = GetResult(TIME_B, MONEY_B);
        PrintResult(costA, costB);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int time, int cost)
    {
        int sum = 0;

        for (int i = 0; i < size; ++i)
        {
            sum += (arr[i] / time + 1) * cost;
        }

        return sum;
    }

    static void PrintResult(int numA, int numB)
    {
        
        if (numA < numB)
        {
            SW.WriteLine($"Y {numA}");
        }
        else if (numA > numB)
        {
            SW.WriteLine($"M {numB}");
        }
        else
        {
            SW.WriteLine($"Y M {numA}");
        }
    }
}