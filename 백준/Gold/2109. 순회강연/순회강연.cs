public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<(int, int)> list;

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());

        SetList(size);
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetList(int size)
    {
        int[] input;

        list = new List<(int, int)>();
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            list.Add((input[0], input[1]));
        }
        list.Sort((a, b) => b.Item1.CompareTo(a.Item1));
    }

    static int GetResult()
    {
        int[] arr = new int[10001];
        int money = 0;

        foreach (var value in list)
        {
            for (int j = value.Item2; j >= 1; --j)
            {
                if (arr[j] == 0)
                {
                    arr[j] = value.Item1;
                    break;
                }
            }
        }

        foreach (int value in arr)
        {
            money += value;
        }

        return money;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}