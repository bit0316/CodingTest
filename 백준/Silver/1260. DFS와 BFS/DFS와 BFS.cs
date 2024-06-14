public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int point;
    static int line;
    static int start;
    static int[] input;
    static bool[] visited;
    static bool[,] map;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];
        start = input[2];

        SetMap();
        DFS(start);
        SW.WriteLine();
        BFS(start);
        SW.WriteLine();

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new bool[point + 1, point + 1];
        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[input[0], input[1]] = true;
            map[input[1], input[0]] = true;
        }
    }

    static void DFS(int depth)
    {
        int pos;
        Stack<int> stack = new Stack<int>();
        visited = new bool[point + 1];

        stack.Push(depth);
        while (stack.Count > 0)
        {
            pos = stack.Pop();
            if (!visited[pos])
            {
                visited[pos] = true;
                SW.Write($"{pos} ");
                for (int i = point; i > 0; --i)
                {
                    if (map[pos, i] && !visited[i])
                    {
                        stack.Push(i);
                    }
                }
            }
        }
    }

    static void BFS(int start)
    {
        int pos;
        Queue<int> queue = new Queue<int>();
        visited = new bool[point + 1];

        queue.Enqueue(start);
        while (queue.Count > 0)
        {
            pos = queue.Dequeue();
            if (!visited[pos])
            {
                visited[pos] = true;
                SW.Write($"{pos} ");
                for (int i = 1; i <= point; ++i)
                {
                    if (map[pos, i] && !visited[i])
                    {
                        queue.Enqueue(i);
                    }
                }
            }
        }
    }
}