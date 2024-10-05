public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static long day;
    static long kg;
    static long[] arr;
    static string[] input;

    static void Main(string[] args)
    {
        long result;

        input = SR.ReadLine().Split();
        day = long.Parse(input[0]);
        kg = long.Parse(input[1]);

        SetArray();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        arr = new long[day];
        
        input = SR.ReadLine().Split();
        for (long i = 0; i < day; ++i)
        {
            arr[i] = long.Parse(input[i]);
        }
    }

    static long GetResult()
    {
        long sum = 0;
        long eat;

        input = SR.ReadLine().Split();
        for (long i = 0; i < day; ++i)
        {
            eat = long.Parse(input[i]);
            sum += eat;

            if (sum < arr[i])
            {
                return -1;
            }
        }

         return (sum - arr[day - 1]) / kg;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}