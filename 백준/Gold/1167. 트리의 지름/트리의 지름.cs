public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<(int, int)>[] map;
    static int size;
    static int[] distances;
    static bool[] visited;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());

        SetMap();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        int index;
        int[] input;

        map = new List<(int, int)>[size + 1];
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[input[0]] = new List<(int, int)>();

            index = 1;
            while (input[index] != -1)
            {
                map[input[0]].Add((input[index], input[index + 1]));
                index += 2;
            }
        }
    }

    static int GetResult()
    {
        if (size == 1)
        {
            return 0;
        }

        int start;

        start = 1;
        DFS(start);

        start = Array.IndexOf(distances, distances.Max());
        DFS(start);

        return distances.Max();
    }

    static void DFS(int depth)
    {
        Stack<(int, int)> stack = new Stack<(int, int)>();
        int node, distance;

        distances = new int[size + 1];
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

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}