public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        int size;
        int last = -1;
        string[] input;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();

            switch (input[0])
            {
                case "push":
                    last = int.Parse(input[1]);
                    Push(queue, last);
                    break;
                case "pop":
                    PrintResult(Pop(queue));
                    break;
                case "size":
                    PrintResult(Size(queue));
                    break;
                case "empty":
                    PrintResult(Empty(queue));
                    break;
                case "front":
                    PrintResult(Front(queue));
                    break;
                case "back":
                    PrintResult(Back(queue, last));
                    break;
            }
        }

        SW.Flush();
        SR.Close();
        SW.Close();
    }

    static void Push(Queue<int> queue, int value)
    {
        queue.Enqueue(value);
    }

    static int Pop(Queue<int> queue)
    {
        return queue.TryDequeue(out int value) ? value : -1;
    }

    static int Size(Queue<int> queue)
    {
        return queue.Count;
    }

    static bool IsEmpty(Queue<int> queue)
    {
        return Size(queue) == 0;
    }

    static int Empty(Queue<int> queue)
    {
        return IsEmpty(queue) ? 1 : 0;
    }

    static int Front(Queue<int> queue)
    {
        return queue.TryPeek(out int value) ? value : -1;
    }

    static int Back(Queue<int> queue, int last)
    {
        return IsEmpty(queue) ? -1 : last;
    }

    static void PrintResult(int num)
    {
        SW.WriteLine(num);
    }
}