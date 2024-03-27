public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int rank;

        size = int.Parse(SR.ReadLine());
        rank = GetRank(size);
        PrintRank(rank);

        SR.Close();
        SW.Close();
    }

    static int GetRank(int size)
    {
        int[] arr = new int[size];
        int min;
        int max;
        float per;
        float avg;
        int rank = 0;

        if (size == 0)
        {
            return 0;
        }

        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }
        Array.Sort(arr);

        per = size * 0.15f;
        per = per - (int)per < 0.5f ? per : per + 1;
        min = (int)per;
        max = size - (int)per;

        for (int i = min; i < max; ++i)
        {
            rank += arr[i];
        }
        avg = (float)rank / (max - min);
        rank = avg - (int)avg < 0.5f ? (int)avg : (int)avg + 1;

        return rank;
    }

    static void PrintRank(int rank)
    {
        SW.WriteLine(rank);
    }
}