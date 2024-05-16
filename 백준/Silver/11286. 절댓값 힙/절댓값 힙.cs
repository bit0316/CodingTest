public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static PriorityQueue<int, int> plusPQ = new PriorityQueue<int, int>();
    static PriorityQueue<int, int> minusPQ = new PriorityQueue<int, int>();
    static int size;
    static int input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        AbsHeap();

        SR.Close();
        SW.Close();
    }

    static void AbsHeap()
    {
        for (int i = 0; i < size; ++i)
        {
            input = int.Parse(SR.ReadLine());
            if (input == 0)
            {
                SW.WriteLine(Pop());
            }
            else
            {
                Push(input);
            }
        }
    }

    static void Push(int value)
    {
        if (value > 0)
        {
            plusPQ.Enqueue(value, value);
        }
        else
        {
            minusPQ.Enqueue(value, Math.Abs(value));
        }
    }

    static int Pop()
    {
        if (plusPQ.Count > 0 && minusPQ.Count > 0)
        {
            if (Math.Abs(plusPQ.Peek()) < Math.Abs(minusPQ.Peek()))
            {
                return plusPQ.Dequeue();
            }
            else
            {
                return minusPQ.Dequeue();
            }
        }
        else if (minusPQ.Count > 0)
        {
            return minusPQ.Dequeue();
        }
        else if (plusPQ.Count > 0)
        {
            return plusPQ.Dequeue();
        }
        else
        {
            return 0;
        }
    }
}