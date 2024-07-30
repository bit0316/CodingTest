public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_NUM = 1000000000;

    static (int, int, int)[] map;
    static int point;
    static int path;
    static int wormhole;
    static int line;
    static int[] distance;
    static int[] input;

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        bool result;

        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            point = input[0];
            path = input[1];
            wormhole = input[2];
            line = path * 2 + wormhole;

            SetMap();
            result = BellmanFord(1);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new (int, int, int)[path * 2 + wormhole];

        for (int i = 0; i < path * 2; i += 2)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[i] = (input[0], input[1], input[2]);
            map[i + 1] = (input[1], input[0], input[2]);
        }

        for (int i = path * 2; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[i] = (input[0], input[1], -input[2]);
        }
    }

    static bool BellmanFord(int index)
    {
        distance = new int[point + 1];
        for (int i = 1; i <= point; ++i)
        {
            distance[i] = MAX_NUM;
        }
        distance[index] = 0;

        int start, end, time;
        for (int i = 1; i < point; ++i)
        {
            foreach (var value in map)
            {
                (start, end, time) = value;
                if (distance[end] > distance[start] + time)
                {
                    distance[end] = distance[start] + time;
                }
            }
        }

        foreach (var value in map)
        {
            (start, end, time) = value;
            if (distance[end] > distance[start] + time)
            {
                return true;
            }
        }

        return false;
    }

    static void PrintResult(bool result)
    {
        if (result)
        {
            SW.WriteLine("YES");
        }
        else
        {
            SW.WriteLine("NO");
        }
    }
}