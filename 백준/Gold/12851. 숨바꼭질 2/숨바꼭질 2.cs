public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_SIZE = 100001;

    static Queue<(int, int)> queue = new Queue<(int, int)>();
    static int start;
    static int end;
    static bool[] visited;

    static void Main(string[] args)
    {
        int[] input;
        int time;
        int count;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        start = input[0];
        end = input[1];

        (time, count) = GetResult(start);
        PrintResult(time, count);

        SR.Close();
        SW.Close();
    }

    static (int, int) GetResult(int depth)
    {
        int num;
        int time = 0;
        int count = 0;
        int min = int.MaxValue;

        queue.Clear();
        visited = new bool[MAX_SIZE];

        queue.Enqueue((depth, time));
        visited[depth] = true;
        while (queue.Count > 0)
        {
            (num, time) = queue.Dequeue();
            visited[num] = true;
            if (num == end && time <= min)
            {
                if (time < min)
                {
                    min = time;
                    count = 1;
                }
                else if (time == min)
                {
                    count++;
                }
                continue;
            }

            if (num - 1 >= 0 && !visited[num - 1])
            {
                queue.Enqueue((num - 1, time + 1));
            }
            if (num + 1 < MAX_SIZE && !visited[num + 1])
            {
                queue.Enqueue((num + 1, time + 1));
            }
            if (num * 2 < MAX_SIZE && !visited[num * 2])
            {
                queue.Enqueue((num * 2, time + 1));
            }
        }

        return (min, count);
    }

    static void PrintResult(int time, int count)
    {
        SW.WriteLine(time);
        SW.WriteLine(count);
    }
}