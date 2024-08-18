public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int num;
        int result;

        size = int.Parse(SR.ReadLine());
        for (int i = 1; i <= size; ++i)
        {
            num = int.Parse(SR.ReadLine());
            result = GetResult(num);
            PrintResult(i, result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult(int num)
    {
        if (num == 0)
        {
            return -1;
        }

        HashSet<int> set = new HashSet<int>();
        int times = 0;
        int multi;

        while (set.Count < 10)
        {
            times++;
            multi = num * times;
            while (multi > 0)
            {
                set.Add(multi % 10);
                multi /= 10;
            }
        }

        return num * times;
    }

    static void PrintResult(int index, int result)
    {
        if (result == -1)
        {
            SW.WriteLine($"Case #{index}: INSOMNIA");
        }
        else
        {
            SW.WriteLine($"Case #{index}: {result}");
        }
    }
}