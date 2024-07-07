public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[][] arr;
    static int[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine()) * 3;

        SetArray();
        GetResult();

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        arr = new int[size][];
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            arr[i] = new int[3] { i + 1, input[0], input[1] };
        }
        arr = arr.OrderBy(y => y[2]).ThenBy(x => x[1]).ToArray();
    }

    static void GetResult()
    {
        for (int i = 0; i < size; i += 3)
        {
            SW.WriteLine($"{arr[i][0]} {arr[i + 1][0]} {arr[i + 2][0]}");
        }
    }
}