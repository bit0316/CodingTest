public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int weight;
    static int[,] arr;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        weight = input[1];

        GetResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        arr = new int[size + 1, weight + 1];
        for (int i = 1; i <= size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 1; j <= weight; ++j)
            {
                arr[i, j] = input[0] > j ? arr[i - 1, j] : Math.Max(arr[i - 1, j], arr[i - 1, j - input[0]] + input[1]);
            }
        }

        SW.WriteLine(arr[size, weight]);
    }
}