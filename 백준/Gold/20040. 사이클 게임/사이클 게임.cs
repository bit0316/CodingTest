public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int point;
    static int line;
    static int[] parent;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];

        InitParent();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void InitParent()
    {
        parent = new int[point];
        for (int i = 0; i < point; ++i)
        {
            parent[i] = i;
        }
    }

    static int GetResult()
    {
        for (int i = 1; i <= line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (Union(input[0], input[1]))
            {
                return i;
            }
        }
        return 0;
    }

    static bool Union(int nodeA, int nodeB)
    {
        nodeA = Find(nodeA);
        nodeB = Find(nodeB);

        if (nodeA != nodeB)
        {
            parent[nodeA] = nodeB;
            return false;
        }
        return true;
    }

    static int Find(int node)
    {
        while (node != parent[node])
        {
            parent[node] = parent[parent[node]];
            node = parent[node];
        }
        return node;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}