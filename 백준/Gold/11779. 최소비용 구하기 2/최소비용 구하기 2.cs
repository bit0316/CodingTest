public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_NUM = 1000000000;

    static List<(int, int)>[] map;
    static Stack<int> path;
    static int point;
    static int line;
    static int cost;
    static int[] input;
    static int[] distance;
    static int[] linked;
    static bool[] visited;

    static void Main(string[] args)
    {
        point = int.Parse(SR.ReadLine());
        line = int.Parse(SR.ReadLine());

        SetMap();

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        Dijkstra(input[0], input[1]);
        GetPath(input[0], input[1]);
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

    static void Dijkstra(int start, int end)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        distance = new int[point + 1];
        linked = new int[point + 1];
        visited = new bool[point + 1];
        int index;

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
                    linked[path.Item1] = index;
                    distance[path.Item1] = distance[index] + path.Item2;
                    pq.Enqueue(path.Item1, distance[path.Item1]);
                }
            }
        }

        cost = distance[end];
    }

    static void GetPath(int start, int end)
    {
        int city = end;

        path = new Stack<int>();

        path.Push(end);
        while (city != start)
        {
            city = linked[city];
            path.Push(city);
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(cost);
        SW.WriteLine(path.Count);
        while (path.Count > 0)
        {
            SW.Write($"{path.Pop()} ");
        }
    }
}