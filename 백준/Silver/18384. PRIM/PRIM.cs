public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_SIZE = 5;
    static int MAX_NUM = 1000000;

    static bool[] isPrime;

    static void Main(string[] args)
    {
        int size;
        int result;
        int[] arr;
        
        size = int.Parse(SR.ReadLine());

        GetPrime(MAX_NUM);
        for (int i = 0; i < size; ++i)
        {
            arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            result = GetResult(arr);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static void GetPrime(int size)
    {
        isPrime = new bool[size];
        for (int i = 2; i < size; ++i)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i < size; ++i)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j < size; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }
    }

    static int GetResult(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < MAX_SIZE; ++i)
        {
            while (!isPrime[arr[i]])
            {
                arr[i]++;
            }
            sum += arr[i];
        }

        return sum;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}