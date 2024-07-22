public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_NUM = 1000000;

    static List<(int, int)>[] map;
    static int point;
    static int line;
    static int start;
    static int[] distance;
    static int[] input;
    static bool[] visited;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];
        start = int.Parse(SR.ReadLine());

        SetMap();
        Dijkstra(start);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new List<(int, int)>[point + 1];
        for (int i = 1; i <= point; ++i)
        {
            map[i] = new List<(int, int)>();
        }

        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[input[0]].Add((input[1], input[2]));
        }
    }

    static void Dijkstra(int start)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        int index;

        distance = new int[point + 1];
        visited = new bool[point + 1];
        for (int i = 1; i <= point; ++i)
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
                if (distance[path.Item1] > distance[index] + path.Item2)
                {
                    distance[path.Item1] = distance[index] + path.Item2;
                    pq.Enqueue(path.Item1, distance[path.Item1]);
                }
            }
        }
    }

    static void PrintResult()
    {
        for (int i = 1; i <= point; ++i)
        {
            if (distance[i] != MAX_NUM)
            {
                SW.WriteLine(distance[i]);
            }
            else
            {
                SW.WriteLine("INF");
            }
        }
    }
}