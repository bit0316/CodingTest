public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int MAX_TIME = 12 * 60;

    static void Main(string[] args)
    {
        int size;
        int result;
        int[] times;

        size = int.Parse(SR.ReadLine());

        times = SetTimes(size);
        result = GetResult(size, times);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[] SetTimes(int size)
    {
        int[] times = new int[size];
        int[] input;

        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(':'), int.Parse);
            times[i] = input[0] * 60 + input[1];
        }

        return times;
    }

    static int GetResult(int size, int[] times)
    {
        HashSet<int> set = new HashSet<int>();
        int min = int.MaxValue;
        int time;

        for (int i = 0; i < MAX_TIME; ++i)
        {
            set.Clear();
            for (int j = 0; j < size; ++j)
            {
                time = (times[j] - i * j) % MAX_TIME;
                if (time < 0)
                {
                    time += MAX_TIME;
                }
                set.Add(time);
            }
            min = Math.Min(min, set.Count);
        }

        return min;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}