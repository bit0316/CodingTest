using System;

public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<int>[] nodes;
    static int point;
    static int root;
    static int query;
    static int[] queries;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        root = input[1];
        query = input[2];

        SetTree();
        GetResult();
        for (int i = 0; i < query; ++i)
        {
            PrintResult(int.Parse(SR.ReadLine()));
        }

        SR.Close();
        SW.Close();
    }

    static void SetTree()
    {
        queries = new int[point + 1];
        nodes = new List<int>[point + 1];

        for (int i = 1; i <= point; ++i)
        {
            nodes[i] = new List<int>();
        }

        for (int i = 0; i < point - 1; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            nodes[input[0]].Add(input[1]);
            nodes[input[1]].Add(input[0]);
        }
    }

    static void GetResult()
    {
        queries[root] = 1;
        foreach (int child in nodes[root])
        {
            queries[root] += GetQuery(child);
        }
    }

    static int GetQuery(int index)
    {
        queries[index] = 1;
        if (nodes[index].Count == 1)
        {
            return queries[index];
        }

        foreach (int child in nodes[index])
        {
            if (queries[child] == 0)
            {
                queries[index] += GetQuery(child);
            }
        }

        return queries[index];
    }

    static void PrintResult(int node)
    {
        SW.WriteLine(queries[node]);
    }
}