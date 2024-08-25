public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<(int, int)>[] map;
    static int size;
    static long[] distances;
    static bool[] visited;

    static void Main(string[] args)
    {
        long result;

        size = int.Parse(SR.ReadLine());

        SetMap();
        result = GetResult(1);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        int[] input;

        map = new List<(int, int)>[size + 1];
        for (int i = 1; i <= size; ++i)
        {
            map[i] = new List<(int, int)>();
        }

        for (int i = 1; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[input[0]].Add((input[1], input[2]));
            map[input[1]].Add((input[0], input[2]));
        }
    }

    static long GetResult(int start)
    {
        if (size == 1)
        {
            return 0;
        }

        DFS(start);

        return distances.Max();
    }

    static void DFS(int depth)
    {
        Stack<(int, long)> stack = new Stack<(int, long)>();
        long distance;
        int node;

        distances = new long[size + 1];
        visited = new bool[size + 1];

        stack.Push((depth, 0));
        visited[depth] = true;
        while (stack.Count > 0)
        {
            (node, distance) = stack.Pop();
            foreach (var value in map[node])
            {
                if (!visited[value.Item1])
                {
                    visited[value.Item1] = true;
                    distances[value.Item1] = distance + value.Item2;
                    stack.Push((value.Item1, distance + value.Item2));
                }
            }
        }
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}