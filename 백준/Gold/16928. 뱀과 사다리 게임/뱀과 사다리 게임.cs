using System.ComponentModel;

public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_MAP_SIZE = 100;

    static int ladder;
    static int snake;
    static int[] map;
    static int[] input;
    static bool[] visited;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        ladder = input[0];
        snake = input[1];

        SetMap(ladder + snake);
        BFS(1);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetMap(int size)
    {
        map = new int[MAX_MAP_SIZE + 1];

        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[input[0]] = input[1];
        }
    }

    static void BFS(int start)
    {
        Queue<int> queue = new Queue<int>();
        int pos;
        int next;
        
        visited = new bool[MAX_MAP_SIZE + 1];
        visited[start] = true;
        queue.Enqueue(start);
        while (queue.Count > 0)
        {
            pos = queue.Dequeue();
            for (int i = 1; i <= 6; ++i)
            {
                if (pos + i > 100)
                {
                    break;
                }

                next = map[pos + i] == 0 ? pos + i : map[pos + i];
                if (!visited[next])
                {
                    map[next] = map[pos] + 1;
                    visited[next] = true;
                    queue.Enqueue(next);
                }
            }
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(map[MAX_MAP_SIZE]);
    }
}