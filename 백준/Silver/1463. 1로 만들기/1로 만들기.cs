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
        int[] arr = new int[num + 1];

        for (int i = 2; i <= num; ++i)
        {
            arr[i] = arr[i-1] + 1;
            if (i % 2 == 0)
            {
                arr[i] = Math.Min(arr[i], arr[i / 2] + 1);
            }
            if (i % 3 == 0)
            {
                arr[i] = Math.Min(arr[i], arr[i / 3] + 1);
            }
        }

        return arr[num];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}