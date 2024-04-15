public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int index = 4;
    static long[] arr;

    static void Main(string[] args)
    {
        int size;
        int order;
        long result;

        size = int.Parse(SR.ReadLine());
        arr = new long[101];

        arr[1] = 1;
        arr[2] = 1;
        arr[3] = 1;
        for (int i = 0; i < size; ++i)
        {
            order = int.Parse(SR.ReadLine());
            result = GetResult(order);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static long GetResult(int num)
    {
        while(index <= num)
        {
            arr[index] = arr[index - 2] + arr[index - 3];
            index++;
        }

        return arr[num];
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}