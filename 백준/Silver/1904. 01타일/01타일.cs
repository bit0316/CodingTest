public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int DIV_SIZE = 15746;

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());
        result = GetResult(size);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int size)
    {
        int[] arr = new int[size + 2];

        arr[1] = 1;
        arr[2] = 2;
        for (int i = 3; i <= size; ++i)
        {
            arr[i] = (arr[i - 1] + arr[i - 2]) % DIV_SIZE;
        }

        return arr[size];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}