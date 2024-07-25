public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_NUM = 1000000000;

    static List<(int, int)>[] map;
    static int point;
    static int line;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        point = int.Parse(SR.ReadLine());
        line = int.Parse(SR.ReadLine());

        SetMap();

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        result = Dijkstra(input[0], input[1]);
        PrintResult(result);

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

    static int Dijkstra(int start, int end)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        int[] distance = new int[point + 1];
        bool[] visited = new bool[point + 1];
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
                    distance[path.Item1] = distance[index] + path.Item2;
                    pq.Enqueue(path.Item1, distance[path.Item1]);
                }
            }
        }

        return distance[end];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}