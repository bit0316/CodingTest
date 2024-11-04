public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] enterTime;
    static int[] exitTime;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        SetMap(size);
        GetResult();

        SR.Close();
        SW.Close();
    }

    static void SetMap(int size)
    {
        int[] input;

        enterTime = new int[size];
        exitTime = new int[size];
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            enterTime[i] = input[0];
            exitTime[i] = input[1];
        }
        Array.Sort(enterTime);
        Array.Sort(exitTime);
    }

    static void GetResult()
    {
        int[] arr = new int[2];
        int enter = 0;
        int exit = 0;
        int max = 0;
        int count = 0;
        int time = 0;

        while (true)
        {
            while (enter < size && enterTime[enter] == time)
            {
                count++;
                enter++;
            }

            if (arr[1] == 0 && count == max)
                arr[1] = time;

            while (exit < size && exitTime[exit] == time)
            {
                count--;
                exit++;
            }

            if (count > max)
            {
                max = count;
                arr[0] = time;
                arr[1] = 0;
            }

            if (enter >= size && exit >= size)
            {
                break;
            }
            time = enter < size ? Math.Min(enterTime[enter], exitTime[exit]) : exitTime[exit];
        }

        SW.WriteLine(max);
        SW.WriteLine($"{arr[0]} {arr[1]}");
    }
}