public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int floor;
    static int length;
    static int[][] map;

    static void Main(string[] args)
    {
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Trim().Split(), int.Parse);
        floor = input[0];
        length = input[1];

        SetMap();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new int[floor][];
        for (int i = 0; i < floor; ++i)
        {
            map[i] = Array.ConvertAll(SR.ReadLine().Trim().Split(), int.Parse);
        }
    }

    static int GetResult()
    {
        int time = 0;
        int curLeft, curRight, nextLeft, nextRight;

        for (int i = 0; i < floor - 1; ++i)
        {
            for (int j = 0; j < length; ++j)
            {
                (curLeft, curRight) = FindDirection(i, time + j);
                (nextLeft, nextRight) = FindDirection(i + 1, time + j);

                if (IsValid(curLeft, curRight, nextLeft, nextRight))
                {
                    time += j;
                    break;
                }
            }
        }

        return time;
    }

    static (int, int) FindDirection(int index, int time)
    {
        int cycle = 2 * (length - map[index][0]);
        if (cycle != 0)
        {
            time %= cycle;
        }

        int left, start, end;
        if (map[index][1] == 0)
        {
            if (time <= (length - map[index][0]))
            {
                start = time;
                end = map[index][0] + time;
            }
            else
            {
                left = time - (length - map[index][0]);
                start = length - map[index][0] - left;
                end = length - left;
            }
        }
        else
        {
            if (time <= (length - map[index][0]))
            {
                start = length - map[index][0] - time;
                end = length - time;
            }
            else
            {
                left = time - (length - map[index][0]);
                start = left;
                end = map[index][0] + left;
            }
        }

        return (start, end);
    }

    static bool IsValid(int curLeft, int curRight, int nextLeft, int nextRight)
    {
        return (curLeft <= nextLeft && nextLeft <= curRight) || (curLeft <= nextRight && nextRight <= curRight) ||
               (nextLeft <= curLeft && curLeft <= nextRight) || (nextLeft <= curRight && curRight <= nextRight);
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}