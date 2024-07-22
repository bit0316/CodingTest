public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_NUM = 1000000000;

    static int[,] map;
    static int point;
    static int line;

    static void Main(string[] args)
    {
        point = int.Parse(SR.ReadLine());
        line = int.Parse(SR.ReadLine());

        InitMap();
        SetMap();
        FloydWarshall();
        PrintResult();

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

    static void SetMap()
    {
        int[] input;

        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (map[input[0], input[1]] > input[2])
            {
                map[input[0], input[1]] = input[2];
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

    static void PrintResult()
    {
        for (int i = 1; i <= point; ++i)
        {
            for (int j = 1; j <= point; ++j)
            {
                if (map[i, j] != MAX_NUM)
                {
                    SW.Write($"{map[i, j]} ");
                }
                else
                {
                    SW.Write($"0 ");
                }
            }
            SW.WriteLine();
        }
    }
}