public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;
        int[] scores;

        size = int.Parse(SR.ReadLine());
        scores = new int[size + 2];

        SetScore(scores, size);
        result = GetResult(scores, size);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetScore(int[] arr, int size)
    {
        for (int i = 1; i <= size; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }
    }

    static int GetResult(int[] scores, int size)
    {
        int[] arr = new int[size + 2];

        arr[1] = scores[1];
        arr[2] = scores[1] + scores[2];
        for (int i = 3; i <= size; ++i)
        {
            arr[i] = scores[i] + Math.Max(arr[i - 2], arr[i - 3] + scores[i - 1]);
        }

        return arr[size];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}