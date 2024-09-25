public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int DIV_SIZE = 1000000000;

    static int[,,] arr;
    static int size;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());
        arr = new int[10, 101, 1024];

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetCount(int num, int digit, int bit)
    {
        if (arr[num, digit, bit] != 0)
        {
            return arr[num, digit, bit];
        }

        if (digit == size)
        {
            return bit == 1023 ? 1 : 0;
        }

        int count = 0;
        int next;

        if (num < 9)
        {
            next = num + 1;
            count += GetCount(next, digit + 1, bit | (1 << next));
        }
        if (num > 0)
        {
            next = num - 1;
            count += GetCount(next, digit + 1, bit | (1 << next));
        }
        arr[num, digit, bit] = count % DIV_SIZE;

        return arr[num, digit, bit];
    }

    static int GetResult()
    {
        int result = 0;

        for (int i = 1; i <= 9; i++)
        {
            result += GetCount(i, 1, 1 << i);
            result %= DIV_SIZE;
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}