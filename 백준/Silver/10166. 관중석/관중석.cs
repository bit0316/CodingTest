public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_SIZE = 2001;
    static bool[,] arr;

    static void Main(string[] args)
    {
        int min, max;
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        min = input[0];
        max = input[1];

        result = GetResult(min, max);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int min, int max)
    {
        int mod;
        int posX, posY;
        int result = 1;

        arr = new bool[MAX_SIZE, MAX_SIZE];
        for (int i = min; i <= max; ++i)
        {
            for (int j = 1; j < i; ++j)
            {
                mod = GetGCD(i, j);
                posX = j / mod;
                posY = i / mod;

                if (!arr[posX, posY])
                {
                    result++;
                    arr[posX, posY] = true;
                }
            }
        }

        return result;
    }

    static int GetGCD(int numA, int numB)
    {
        int remain = numA % numB;

        return remain != 0 ? GetGCD(numB, remain) : numB;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}