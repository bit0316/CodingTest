public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int limit;
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        limit = input[1];

        result = GetResult(size, limit);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int size, int limit)
    {
        List<int> list = new List<int>();
        int[] arr = new int[size + 1];

        for (int i = 1; i <= size; ++i)
        {
            if (i % GetSumDigit(i) == 0)
            {
                list.Add(i);
            }
        }

        arr[0] = 1;
        foreach (int num in list)
        {
            for (int i = num; i <= size; ++i)
            {
                arr[i] = (arr[i] + arr[i - num]) % limit;
            }
        }

        return arr[size];
    }

    static int GetSumDigit(int num)
    {
        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        
        return sum;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}