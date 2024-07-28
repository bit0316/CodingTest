public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] arr;

    static void Main(string[] args)
    {
        long result;

        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult()
    {
        long odd = 0;
        long even = 0;

        for (int i = 1; i <= size; ++i)
        {
            if (i % 2 == 0)
            {
                even += arr[i - 1];
            }
            else
            {
                odd += arr[i - 1];
            }
        }

        return size > 3 || even >= odd ? Math.Abs(odd - even) : -1;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}