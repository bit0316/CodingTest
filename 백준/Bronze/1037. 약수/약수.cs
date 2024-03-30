public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;
        int[] arr;
        string[] input;

        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetResult(arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int[] arr)
    {
        int size = arr.Length;

        Array.Sort(arr);

        return arr[0] * arr[size - 1];
    }

    static void PrintResult(long value)
    {
        SW.WriteLine(value);
    }
}