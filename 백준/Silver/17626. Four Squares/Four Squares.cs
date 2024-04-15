public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int[] arr;

    static void Main(string[] args)
    {
        int num;
        int result;

        num = int.Parse(SR.ReadLine());
        arr = new int[num + 1];

        result = GetResult(num);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int num)
    {
        for (int i = 1; i <= num; ++i)
        {
            arr[i] = arr[i - 1] + 1;
            for (int j = 1; j * j <= i; ++j)
            {
                arr[i] = Math.Min(arr[i], arr[i - j * j] + 1);
            }
        }

        return arr[num];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}