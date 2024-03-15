public class Program
{
    static void Main(string[] args)
    {
        int size;
        int limit;
        int[] arr;
        string[] input;

        input = Console.ReadLine().Split();
        size = int.Parse(input[0]);
        limit = int.Parse(input[1]);
        arr = new int[size];

        input = Console.ReadLine().Split();
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }

        arr = SortArray(arr);
        PrintCutOfLine(arr, limit);
    }

    static int[] SortArray(int[] arr)
    {
        int size = arr.Length;
        int index;
        int min;

        for (int i = 0; i < size - 1; ++i)
        {
            index = i;
            min = arr[i];
            for (int j = i; j < size; ++j)
            {
                if (arr[j] < min)
                {
                    index = j;
                    min = arr[j];
                }
            }

            if (min != arr[i])
            {
                (arr[i], arr[index]) = (arr[index], arr[i]);
            }
        }

        return arr;
    }

    static void PrintCutOfLine(int[] arr, int limit)
    {
        Console.WriteLine(arr[arr.Length - limit]);
    }
}