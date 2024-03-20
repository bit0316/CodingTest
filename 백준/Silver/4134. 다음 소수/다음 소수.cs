public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        long size;
        long[] arr;

        size = long.Parse(SR.ReadLine());
        arr = new long[size];

        SetArray(arr, size);
        PrintResult(arr);

        SR.Close();
        SW.Close();
    }

    static void SetArray(long[] arr, long size)
    {
        for (int i = 0; i < size; ++i)
        {
            arr[i] = long.Parse(SR.ReadLine());
        }
    }

    static bool IsPrime(long num)
    {
        if (num <= 1)
        {
            return false;
        }
        else if (num == 2 || num == 3)
        {
            return true;
        }
        else if (num % 2 == 0 || num % 3 == 0)
        {
            return false;
        }

        for (long i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }

    static long GetPrime(long num)
    {
        while (!IsPrime(num))
        {
            num++;
        }

        return num;
    }

    static void PrintResult(long[] arrA)
    {
        long size = arrA.Length;

        for (long i = 0; i < size; ++i)
        {
            SW.WriteLine(GetPrime(arrA[i]));
        }

        SW.Flush();
    }
}