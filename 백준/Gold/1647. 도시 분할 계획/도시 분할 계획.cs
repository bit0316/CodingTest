public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<(int, int)>[] map;
    static int point;
    static int line;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];

        SetMap();
        result = GetResult(1);
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
            map[input[1]].Add((input[0], input[2]));
        }
    }

    static int GetResult(int start)
    {
        PriorityQueue<(int, int), int> pq = new PriorityQueue<(int, int), int>();
        bool[] visited = new bool[point + 1];
        int sum = 0;
        int max = 0;
        int index, cost;

        pq.Enqueue((start, 0), 0);
        while (pq.Count > 0)
        {
            (index, cost) = pq.Dequeue();
            if (visited[index])
            {
                continue;
            }

            visited[index] = true;
            sum += cost;
            max = Math.Max(max, cost);
            foreach (var path in map[index])
            {
                if (!visited[path.Item1])
                {
                    pq.Enqueue((path.Item1, path.Item2), path.Item2);
                }
            }
        }

        return sum - max;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}