public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Queue<(int, int)> queue = new Queue<(int, int)>();
    static int size;
    static int[] arr;
    static int[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = new int[size];

        SetQueue();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetQueue()
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        for (int i = 0; i < size; ++i)
        {
            queue.Enqueue((i, input[i]));
        }
    }

    static void GetResult()
    {
        int order;
        int remain;
        int count = 0;

        while (queue.Count > 0)
        {
            count++;
            (order, remain) = queue.Dequeue();
            if (remain > 1)
            {
                queue.Enqueue((order, remain - 1));
            }
            else
            {
                arr[order] = count;
            }
        }
    }

    static void PrintResult()
    {
        for (int i = 0; i < size; ++i)
        {
            SW.Write($"{arr[i]} ");
        }
    }
}