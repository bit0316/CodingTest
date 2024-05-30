public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static List<int>[] list;
    static int[] parent;
    static bool[] visited;
    static int[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        list = new List<int>[size + 1];
        parent = new int[size + 1];
        visited = new bool[size + 1];

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        for (int i = 0; i <= size; ++i)
        {
            list[i] = new List<int>();
        }

        for (int i = 1; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            list[input[0]].Add(input[1]);
            list[input[1]].Add(input[0]);
        }

        DFS(1);
    }

    static void DFS(int index)
    {
        visited[index] = true;
        foreach (int node in list[index])
        {
            if (!visited[node])
            {
                parent[node] = index;
                DFS(node);
            }
        }
    }

    static void PrintResult()
    {
        for (int i = 2; i <= size; ++i)
        {
            SW.WriteLine(parent[i]);
        }
    }
}