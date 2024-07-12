public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<int, int> dict = new Dictionary<int, int>();
    static PriorityQueue<int, int> minQueue = new PriorityQueue<int, int>();
    static PriorityQueue<int, int> maxQueue = new PriorityQueue<int, int>();

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            GetResult();
            PrintResult();
        }

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int size = int.Parse(SR.ReadLine());
        int num;
        string[] input;

        dict.Clear();
        minQueue.Clear();
        maxQueue.Clear();
        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            if (input[0] == "I")
            {
                num = int.Parse(input[1]);
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                    minQueue.Enqueue(num, num);
                    maxQueue.Enqueue(num, -num - 1);
                }
            }
            else if (input[0] == "D" && dict.Count > 0)
            {
                if (input[1] == "-1")
                {
                    CheckQueue(minQueue);
                    CheckDictionary(minQueue);
                    CheckQueue(maxQueue);
                }
                else if (input[1] == "1")
                {
                    CheckQueue(maxQueue);
                    CheckDictionary(maxQueue);
                    CheckQueue(minQueue);
                }
            }
        }
        CheckQueue(minQueue);
        CheckQueue(maxQueue);
    }

    static void CheckQueue(PriorityQueue<int, int> queue)
    {
        while (queue.Count > 0 && !dict.ContainsKey(queue.Peek()))
        {
            queue.Dequeue();
        }
    }

    static void CheckDictionary(PriorityQueue<int, int> queue)
    {
        if (dict[queue.Peek()] > 1)
        {
            dict[queue.Peek()]--;
        }
        else
        {
            dict.Remove(queue.Dequeue());
        }
    }

    static void PrintResult()
    {
        if (dict.Count > 0)
        {
            SW.WriteLine($"{maxQueue.Peek()} {minQueue.Peek()}");
        }
        else
        {
            SW.WriteLine("EMPTY");
        }
    }
}