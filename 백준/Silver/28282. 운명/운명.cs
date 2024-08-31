public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<int, int> left = new Dictionary<int, int>();
    static Dictionary<int, int> right = new Dictionary<int, int>();
    static string[] input;
    static int[] colors;

    static void Main(string[] args)
    {
        long result;

        input = SR.ReadLine().Split();
        int pairs = int.Parse(input[0]);
        int color = int.Parse(input[1]);

        SetSocks(pairs);
        result = GetResult(pairs);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetSocks(int pairs)
    {
        int size = pairs * 2;

        input = SR.ReadLine().Split();

        colors = new int[size];
        for (int i = 0; i < size; ++i)
        {
            colors[i] = int.Parse(input[i]);
        }
    }

    static long GetResult(int pairs)
    {
        long count = 0;

        GetSocksCount(left, 0, pairs);
        GetSocksCount(right, pairs, pairs * 2);

        foreach (var socks in left)
        {
            count += (long)socks.Value * pairs;
            if (right.ContainsKey(socks.Key))
            {
                count -= (long)socks.Value * right[socks.Key];
            }
        }

        return count;
    }

    static void GetSocksCount(Dictionary<int, int> pair, int start, int count)
    {
        int kind;

        for (int i = start; i < count; ++i)
        {
            kind = int.Parse(input[i]);
            if (pair.ContainsKey(kind))
            {
                pair[kind]++;
            }
            else
            {
                pair.Add(kind, 1);
            }
        }
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}