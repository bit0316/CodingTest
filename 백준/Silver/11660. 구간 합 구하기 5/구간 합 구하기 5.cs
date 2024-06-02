public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int count;
    static int[,] arr;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        count = input[1];

        SetArray();
        for (int i = 0; i < count; ++i)
        {
            result = GetResult();
            SW.WriteLine(result);
        }

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        arr = new int[size + 1, size + 1];
        for (int i = 1; i <= size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 1; j <= size; ++j)
            {
                arr[i, j] = arr[i - 1, j] + arr[i, j - 1] - arr[i - 1, j - 1]  + input[j - 1];
            }
        }
    }

    static int GetResult()
    {
        int x1, y1, x2, y2;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        x1 = input[0] - 1;
        y1 = input[1] - 1;
        x2 = input[2];
        y2 = input[3];

        return arr[x2, y2] - arr[x1, y2] - arr[x2, y1] + arr[x1, y1];
    }
}