public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int[] input;
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetResult(input[0], input[1], input[2]);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int count, int width, int limit)
    {
        Queue<int> trucks = new Queue<int>();
        Queue<int> bridge = new Queue<int>();
        string[] input;
        int time = 0;

        input = SR.ReadLine().Split();
        for (int i = 0; i < count; ++i)
        {
            trucks.Enqueue(int.Parse(input[i]));
        }

        for (int i = 0; i < width; ++i)
        {
            bridge.Enqueue(0);
        }

        while (bridge.Count > 0)
        {
            time++;
            bridge.Dequeue();
            if (trucks.Count > 0)
            {
                int currentWeight = bridge.Sum();
                if (currentWeight + trucks.Peek() <= limit)
                {
                    bridge.Enqueue(trucks.Dequeue());
                }
                else
                {
                    bridge.Enqueue(0);
                }
            }
        }

        return time;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}