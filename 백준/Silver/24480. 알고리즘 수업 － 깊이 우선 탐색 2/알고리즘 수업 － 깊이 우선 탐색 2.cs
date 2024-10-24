public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        List<int>[] map;
        int point, line, start;
        int[] order;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];
        start = input[2];

        map = SetMap(point, line);
        order = GetResult(start, point, map);
        PrintResult(point, order);

        SR.Close();
        SW.Close();
    }

    static List<int>[] SetMap(int point, int line)
    {
        List<int>[] map = new List<int>[point + 1];
        int[] input;

        for (int i = 1; i <= point; ++i)
        {
            map[i] = new List<int>();
        }

        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[input[0]].Add(input[1]);
            map[input[1]].Add(input[0]);
        }

        for (int i = 1; i <= point; ++i)
        {
            map[i].Sort();
        }

        return map;
    }

    static int[] GetResult(int node, int point, List<int>[] map)
    {
        Stack<int> stack = new Stack<int>();
        bool[] visited = new bool[point + 1];
        int[] order = new int[point + 1];
        int index = 1;

        stack.Push(node);
        while (stack.Count > 0)
        {
            node = stack.Pop();
            if (!visited[node])
            {
                visited[node] = true;
                order[node] = index++;
                foreach (int num in map[node])
                {
                    stack.Push(num);
                }
            }
        }

        return order;
    }

    static void PrintResult(int point, int[] order)
    {
        for (int i = 1; i <= point; ++i)
        {
            SW.WriteLine(order[i]);
        }
    }
}