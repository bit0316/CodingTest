public class Program
{
    static void Main(string[] args)
    {
        int size = 5;
        int[] arr = new int[size];
        
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        arr = SortArray(arr);
        PrintResult(arr);
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

    static void PrintResult(int[] arr)
    {
        int avg;
        int mid;
        int sum = 0;
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            sum += arr[i];
        }
        avg = sum / size;
        mid = arr[size / 2];

        Console.WriteLine(avg);
        Console.WriteLine(mid);
    }
}