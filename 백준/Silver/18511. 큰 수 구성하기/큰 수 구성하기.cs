public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int num;
    static int result;
    static int[] arr;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        num = input[0];
        size = input[1];

        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        arr = arr.OrderBy(x => x).Reverse().ToArray();

        DFS(0);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void DFS(int value)
    {
        if (value > num)
        {
            return;
        }

        if (result < value)
        {
            result = value;
        }

        for (int i = 0; i < size; ++i)
        {
            DFS(value * 10 + arr[i]);
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}