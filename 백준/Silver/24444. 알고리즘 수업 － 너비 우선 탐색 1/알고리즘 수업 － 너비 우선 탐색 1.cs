using System.Xml.Linq;

public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<int>[] map;
    static int point;
    static int line;
    static int start;
    static int[] order;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];
        start = input[2];

        SetMap();
        BFS(start);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new List<int>[point + 1];
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
    }

    static void BFS(int start)
    {
        Queue<int> queue = new Queue<int>();
        order = new int[point + 1];
        int index = 1;
        int node;

        queue.Enqueue(start);
        order[start] = index++;
        while (queue.Count > 0)
        {
            node = queue.Dequeue();
            foreach (int pos in map[node])
            {
                if (order[pos] == 0)
                {
                    queue.Enqueue(pos);
                    order[pos] = index++;
                }
            }
        }
    }

    static void PrintResult()
    {
        for (int i = 1; i <= point; ++i)
        {
            SW.WriteLine(order[i]);
        }
    }
}