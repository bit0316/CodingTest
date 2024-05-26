public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[][] arr;
    static int[][] result;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        arr = new int[size][];
        for (int i = 0; i < size; ++i)
        {
            arr[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        }

        GetResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        result = new int[size][];
        result[size - 1] = arr[size - 1];
        for (int i = size - 2; i >= 0; --i)
        {
            result[i] = new int[i + 1];
            for (int j = 0; j <= i; ++j)
            {
                result[i][j] = Math.Max(result[i + 1][j], result[i + 1][j + 1]);
                result[i][j] += arr[i][j];
            }
        }

        SW.WriteLine(result[0][0]);
    }
}