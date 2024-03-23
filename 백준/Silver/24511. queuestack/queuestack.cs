public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        Queue<int> queue;
        int[] result;
        int sizeA;
        int sizeB;

        sizeA = int.Parse(SR.ReadLine());
        queue = QueueStack(sizeA);

        sizeB = int.Parse(SR.ReadLine());
        result = GetResult(queue, sizeB);
        PrintResult(result, sizeB);

        SW.Flush();
        SR.Close();
        SW.Close();
    }

    static Queue<int> QueueStack(int size)
    {
        Queue<int> queue = new Queue<int>();
        int[] queueStack = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int[] value = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        for (int i = size - 1; i >= 0; --i)
        {
            if (queueStack[i] == 0)
            {
                queue.Enqueue(value[i]);
            }
        }

        return queue;
    }

    static int[] GetResult(Queue<int> queue, int size)
    {
        int[] result = new int[size];
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int index = 0;

        for (int i = 0; i < size; ++i)
        {
            result[i] = queue.TryDequeue(out int value) ? value : input[index++];
        }

        return result;
    }

    static void PrintResult(int[] arr, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            SW.Write($"{arr[i]} ");
        }
    }
}