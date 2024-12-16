public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;
        int[] arr;

        size = int.Parse(SR.ReadLine());
        arr = SetArray(size);
        result = GetResult(arr, size);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[] SetArray(int size)
    {
        int[] arr = new int[size + 1];
        string[] input = SR.ReadLine().Split();

        for (int i = 1; i <= size; ++i)
        {
            arr[i] = int.Parse(input[i - 1]);
        }

        return arr;
    }

    static int GetResult(int[] arr, int size)
    {
        int count = 0;
        int[] input;

        for (int i = 0; i < size - 1; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (arr[input[0]] != arr[input[1]])
            {
                count++;
            }
        }

        return arr[1] != 0 ? count + 1 : count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}