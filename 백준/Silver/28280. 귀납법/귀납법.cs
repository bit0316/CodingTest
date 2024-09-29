public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int MAX_NUM = 4000000;

    static void Main(string[] args)
    {
        int size;
        int num;
        int result;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(SR.ReadLine());
            result = GetResult(num);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult(int end)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        bool[] visited = new bool[MAX_NUM];
        int start = 1;
        int count;

        queue.Enqueue((start, 0));
        while (queue.Count > 0)
        {
            (start, count) = queue.Dequeue();
            if (start == end)
            {
                return count;
            }
            
            if (start >= 0 && start < MAX_NUM && !visited[start])
            {
                queue.Enqueue((start * 2, count + 1));
                queue.Enqueue((start - 1, count + 1));
                visited[start] = true;
            }
        }

        return -1;
    }

    static void PrintResult(int result)
    {
        if (result == -1)
        {
            SW.WriteLine("Wrong proof!");
        }
        else
        {
            SW.WriteLine(result);
        }
    }
}