public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] rank;

        size = int.Parse(SR.ReadLine());
        rank = new int[size];

        GetRank(rank, size);
        PrintArray(rank, size);

        SR.Close();
        SW.Close();
    }

    static void GetRank(int[] rank, int size)
    {
        int[,] arr = new int[size, 2];
        int count;
        string[] input;

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            arr[i, 0] = int.Parse(input[0]);
            arr[i, 1] = int.Parse(input[1]);
        }

        for (int i = 0; i < size; ++i)
        {
            count = 1;
            for (int j = 0; j < size; ++j)
            {
                if (arr[i, 0] < arr[j, 0] && arr[i, 1] < arr[j, 1])
                {
                    count++;
                }
            }
            rank[i] = count;
        }
    }

    static void PrintArray(int[] arr, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            SW.Write($"{arr[i]} ");
        }
        SW.WriteLine();
    }
}