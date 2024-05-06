public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());
    static int MAX_SIZE = 100001;

    static int start;
    static int end;
    static bool[] isVisited = new bool[MAX_SIZE];
    static Queue<(int, int)> queue = new Queue<(int, int)>();

    static void Main(string[] args)
    {
        int[] input;
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        start = input[0];
        end = input[1];

        result = GetResult(start);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int depth)
    {
        int num;
        int count = 0;

        queue.Enqueue((depth, count));
        isVisited[depth] = true;
        while (queue.Count > 0)
        {
            (num, count) = queue.Dequeue();
            if (num == end)
            {
                break;
            }

            if (num - 1 >= 0 && !isVisited[num - 1])
            {
                queue.Enqueue((num - 1, count + 1));
                isVisited[num - 1] = true;
            }
            if (num + 1 < MAX_SIZE && !isVisited[num + 1])
            {
                queue.Enqueue((num + 1, count + 1));
                isVisited[num + 1] = true;
            }
            if (num * 2 < MAX_SIZE && !isVisited[num * 2])
            {
                queue.Enqueue((num * 2, count + 1));
                isVisited[num * 2] = true;
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}