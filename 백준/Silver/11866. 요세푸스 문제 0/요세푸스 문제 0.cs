public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        Queue<int> result = new Queue<int>();
        int size;
        int order;
        string[] input;

        input = SR.ReadLine().Split();
        size = int.Parse(input[0]);
        order = int.Parse(input[1]);

        SetCircle(queue, size);
        result = GetJosephus(queue, order);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetCircle(Queue<int> queue, int size)
    {
        for (int i = 1; i <= size; ++i)
        {
            queue.Enqueue(i);
        }
    }

    static Queue<int> GetJosephus(Queue<int> queue, int order)
    {
        Queue<int> result = new Queue<int>();

        while (queue.Count > 0)
        {
            for (int i = 0; i < order - 1; ++i)
            {
                queue.Enqueue(queue.Dequeue());
            }
            result.Enqueue(queue.Dequeue());
        }

        return result;
    }

    static void PrintResult(Queue<int> queue)
    {
        int size = queue.Count;

        SW.Write("<");
        for (int i = 0; i < size - 1; ++i)
        {
            SW.Write($"{queue.Dequeue()}, ");
        }
        SW.Write(queue.Dequeue());
        SW.WriteLine(">");

        SW.Flush();
    }
}