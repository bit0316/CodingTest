public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;
        int result;

        num = int.Parse(SR.ReadLine());

        result = GetFibonacci(num);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetFibonacci(int num)
    {
        int[] arr = new int[num + 2];

        arr[1] = 1;
        for (int i = 2; i <= num; ++i)
        {
            arr[i] = arr[i - 2] + arr[i - 1];
        }

        return arr[num];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}