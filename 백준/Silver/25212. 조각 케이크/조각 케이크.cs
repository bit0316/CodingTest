public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const double PIECE_MIN = 0.99;
    const double PIECE_MAX = 1.01;

    static void Main(string[] args)
    {
        double[] arr;
        int size;
        int result;

        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), double.Parse);

        result = GetResult(size, arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int size, double[] arr)
    {
        return DFS(0, 0, size, arr);
    }

    static int DFS(double total, int index, int size, double[] arr)
    {
        if (total >= PIECE_MIN && total <= PIECE_MAX)
        {
            return 1;
        }
        if (index >= size || total > PIECE_MAX)
        {
            return 0;
        }

        return DFS(total, index + 1, size, arr) + DFS(total + 1 / arr[index], index + 1, size, arr);
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}