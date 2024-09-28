public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static long MAX_NUM = 50000000000;

    static List<(int, int)>[] map;
    static int point;
    static int line;
    static int[] sight;
    static int[] input;

    static void Main(string[] args)
    {
        long result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];

        SetSight();
        SetMap();

        result = Dijkstra(0, point - 1);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new List<(int, int)>[point];
        for (int i = 0; i < point; ++i)
        {
            map[i] = new List<(int, int)>();
        }

        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[input[0]].Add((input[1], input[2]));
            map[input[1]].Add((input[0], input[2]));
        }
    }

    static void SetSight()
    {
        sight = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        sight[point - 1] = 0;
    }

    static long Dijkstra(int start, int end)
    {
        PriorityQueue<int, long> pq = new PriorityQueue<int, long>();
        long[] distance = new long[point];
        bool[] visited = new bool[point];
        int index;

        for (int i = 0; i < point; ++i)
        {
            distance[i] = MAX_NUM;
        }

        pq.Enqueue(start, 0);
        distance[start] = 0;
        while (pq.Count > 0)
        {
            index = pq.Dequeue();
            if (visited[index])
            {
                continue;
            }

            visited[index] = true;
            foreach (var path in map[index])
            {
                if (sight[path.Item1] == 0 && distance[path.Item1] > distance[index] + path.Item2)
                {
                    distance[path.Item1] = distance[index] + path.Item2;
                    pq.Enqueue(path.Item1, distance[path.Item1]);
                }
            }
        }

        return distance[end];
    }

    static void PrintResult(long result)
    {
        if (result < MAX_NUM)
        {
            SW.WriteLine(result);
        }
        else
        {
            SW.WriteLine(-1);
        }
    }
}