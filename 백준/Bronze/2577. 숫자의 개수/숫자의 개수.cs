public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = 3;
        int mult;
        int[] numbers = new int[size];
        int[] counts = new int[10];

        SetNumbers(numbers, size);
        mult = GetMultiple(numbers);
        GetCounts(counts, mult);
        PrintResult(counts);

        SR.Close();
        SW.Close();
    }

    static void SetNumbers(int[] numbers, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            numbers[i] = int.Parse(SR.ReadLine());
        }
    }

    static int GetMultiple(int[] numbers)
    {
        int result = 1;

        foreach (int number in numbers)
        {
            result *= number;
        }

        return result;
    }

    static void GetCounts(int[] counts, int num)
    {
        while (num > 0)
        {
            counts[num % 10]++;
            num /= 10;
        }
    }

    static void PrintResult(int[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            SW.WriteLine(arr[i]);
        }

        SW.Flush();
    }
}