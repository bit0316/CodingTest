public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;
        int result;

        num = int.Parse(SR.ReadLine());

        result = GetResult(num);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int num)
    {
        int[] arr = new int[num + 2];

        arr[1] = 1;
        arr[2] = 2;
        for (int i = 3; i <= num; ++i)
        {
            arr[i] = (arr[i - 1] + arr[i - 2]) % 10007;
        }

        return arr[num];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}