public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;
        int[] price;

        size = int.Parse(SR.ReadLine());

        price = SetPrice(size);
        result = GetResult(size, price);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[] SetPrice(int size)
    {
        int[] arr = new int[size + 1];

        for (int i = 1; i <= size; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }

        return arr;
    }

    static int GetResult(int size, int[] price)
    {
        int[,] arr;
        int sum;

        arr = new int[size + 1, size + 1];
        for (int i = 1; i <= size; ++i)
        {
            arr[i, i] = price[i];
        }

        for (int i = 1; i < size; ++i)
        {
            for (int j = 1; j <= (size - i); ++j)
            {
                sum = 0;
                for (int k = j; k <= j + i; ++k)
                {
                    sum += price[k];
                }
                arr[j, j + i] = Math.Max(arr[j, j + i - 1], arr[j + 1, j + i]) + sum;
            }
        }

        return arr[1, size];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}