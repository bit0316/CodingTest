public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<(int, int, int)> edges = new List<(int, int, int)>();
    static int point, line, turn;
    static int[] parents;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];
        turn = input[2];

        SetParents();
        GetResult();

        SR.Close();
        SW.Close();
    }

    static void SetParents()
    {
        parents = new int[point + 1];
        for (int i = 1; i <= line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            edges.Add((i, input[0], input[1]));
        }
    }

    static void GetResult()
    {
        int sum = 0;

        for (int i = 0; i < turn; ++i)
        {
            if (sum == -1)
            {
                SW.Write("0 ");
            }
            else
            {
                sum = FindMST();
                SW.Write(sum == -1 ? "0 " : $"{sum} ");
                if (edges.Count > 0)
                {
                    edges.RemoveAt(0);
                }
            }
        }
    }

    static int FindMST()
    {
        int sum = 0;
        int count = 0;
        int numA, numB;

        for (int i = 1; i <= point; ++i)
        {
            parents[i] = i;
        }

        foreach (var edge in edges)
        {
            numA = Find(edge.Item2);
            numB = Find(edge.Item3);
            if (numA != numB)
            {
                Union(numA, numB);
                sum += edge.Item1;
                count++;
            }
        }

        return count != point - 1 ? -1 : sum;
    }

    static int Find(int x)
    {
        return parents[x] == x ? x : (parents[x] = Find(parents[x]));
    }

    static void Union(int a, int b)
    {
        a = Find(a);
        b = Find(b);
        if (a < b)
        {
            parents[b] = a;
        }
        else
        {
            parents[a] = b;
        }
    }
}