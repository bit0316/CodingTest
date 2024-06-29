public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] arr;
    static long result;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        result = arr[size - 1];
        for (int i = size - 2; i >= 0; i--)
        {
            if (result % arr[i] != 0)
            {
                result = arr[i] * (result / arr[i] + 1);
            }
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}