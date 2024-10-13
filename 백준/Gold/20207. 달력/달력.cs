public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int MAX_SIZE = 1000;

    static void Main(string[] args)
    {
        int[] calendar;
        int size;
        int max;
        int result;

        size = int.Parse(SR.ReadLine());

        (calendar, max) = SetCalendar(size);
        result = GetResult(max, calendar);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static (int[], int) SetCalendar(int size)
    {
        int[] calendar;
        int[] input;
        int start, end;
        int max = 0;

        calendar = new int[MAX_SIZE + 1];
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            start = input[0];
            end = input[1];
            max = Math.Max(end, max);

            for (int j = start; j <= end; ++j)
            {
                calendar[j]++;
            }
        }
        return (calendar, max);
    }

    static int GetResult(int max, int[] calendar)
    {
        int row = 0;
        int col = 0;
        int result = 0;

        for (int i = 0; i <= max + 1; ++i)
        {
            if (calendar[i] == 0)
            {
                result += row * col;
                row = 0;
                col = 0;
                continue;
            }

            col++;
            row = Math.Max(row, calendar[i]);
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}