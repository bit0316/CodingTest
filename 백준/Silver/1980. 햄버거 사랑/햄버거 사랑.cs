public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int burgerA;
        int burgerB;
        int time;
        int count;
        int coke;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        burgerA = input[0];
        burgerB = input[1];
        time = input[2];

        (count, coke) = GetResult(burgerA, burgerB, time);
        PrintResult(count, coke);

        SR.Close();
        SW.Close();
    }

    static (int, int) GetResult(int burgerA, int burgerB, int time)
    {
        int min = Math.Min(burgerA, burgerB);
        int max = Math.Max(burgerA, burgerB);
        int coke = int.MaxValue;
        int remain = time;
        int countA = 0;
        int countB = 0;

        while (remain >= 0)
        {
            if (remain % min < coke)
            {
                countA = remain / min;
                coke = remain % min;
            }

            countB++;
            remain = time - max * countB;
        }
        countB = (time - min * countA) / max;

        return (countA + countB, coke);
    }

    static void PrintResult(int count, int coke)
    {
        SW.WriteLine($"{count} {coke}");
    }
}