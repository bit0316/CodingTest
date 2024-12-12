public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int question;
        int result;
        int[] arr;
        int[] mistakes;
        int[] input;

        size = int.Parse(SR.ReadLine());
        arr = SetArray(size);
        mistakes = GetMistakes(arr, size);

        question = int.Parse(SR.ReadLine());
        for (int i = 0; i < question; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            result = GetResult(mistakes, input[0], input[1]);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int[] SetArray(int size)
    {
        int[] arr = new int[size];
        string[] input;

        input = SR.ReadLine().Split();
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }

        return arr;
    }

    static int[] GetMistakes(int[] arr, int size)
    {
        int[] mistakes = new int[size];

        for (int i = 1; i < size; ++i)
        {
            mistakes[i] = arr[i - 1] > arr[i] ? mistakes[i - 1] + 1 : mistakes[i - 1];
        }

        return mistakes;
    }

    static int GetResult(int[] mistakes, int start, int end)
    {
        return mistakes[end - 1] - mistakes[start - 1];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}