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
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];

        SetParent();
        GetResult();

        SR.Close();
        SW.Close();
    }

    static void SetParent()
    {
        parent = new int[point + 1];
        for (int i = 1; i <= point; ++i)
        {
            parent[i] = -int.Parse(SR.ReadLine());
        }
    }

    static void GetResult()
    {
        int nodeA, nodeB;

        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            nodeA = input[0];
            nodeB = input[1];

            Union(nodeA, nodeB);

            SW.WriteLine(-parent[Find(nodeA)]);
        }
    }

    static void Union(int nodeA, int nodeB)
    {
        nodeA = Find(nodeA);
        nodeB = Find(nodeB);

        if (nodeA != nodeB)
        {
            (parent[nodeA], parent[nodeB]) = (parent[nodeA] + parent[nodeB], nodeA); 
        }
    }

    static int Find(int a)
    {
        return parent[a] < 0 ? a : (parent[a] = Find(parent[a]));
    }
}