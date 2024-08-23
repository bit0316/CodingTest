public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_NUM = 1000000000;

    static int[,] map;
    static int[] items;
    static int point;
    static int range;
    static int line;
    static int[] input;


    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        range = input[1];
        line = input[2];

        InitMap();
        SetItem();
        SetMap();
        FloydWarshall();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void InitMap()
    {
        map = new int[point + 1, point + 1];
        for (int i = 1; i <= point; ++i)
        {
            for (int j = 1; j <= point; ++j)
            {
                if (i != j)
                {
                    map[i, j] = MAX_NUM;
                }
            }
        }
    }

    static void SetItem()
    {
        items = new int[point + 1];

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        for (int i = 1; i <= point; ++i)
        {
            items[i] = input[i - 1];
        }
    }

    static void SetMap()
    {
        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (map[input[0], input[1]] > input[2])
            {
                map[input[0], input[1]] = input[2];
                map[input[1], input[0]] = input[2];
            }
        }
    }

    static void FloydWarshall()
    {
        for (int i = 1; i <= point; ++i)
        {
            for (int j = 1; j <= point; ++j)
            {
                for (int k = 1; k <= point; ++k)
                {
                    if (map[j, k] > map[j, i] + map[i, k])
                    {
                        map[j, k] = map[j, i] + map[i, k];
                    }
                }
            }
        }
    }

    static int GetResult()
    {
        int max;
        int sum;

        max = 0;
        for (int i = 1; i <= point; ++i)
        {
            sum = 0;
            for (int j = 1; j <= point; ++j)
            {
                if (map[i, j] <= range)
                {
                    sum += items[j];
                }
            }

            if (max < sum)
            {
                max = sum;
            }
        }

        return max;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}