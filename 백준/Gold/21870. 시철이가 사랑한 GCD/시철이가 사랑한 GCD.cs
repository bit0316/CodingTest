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
        result = GetResult(size, arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[] SetArray(int size)
    {
        int[] arr = new int[size];
        string[] input = SR.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }

        return arr;
    }

    static int GetResult(int size, int[] arr)
    {
        if (size < 2)
        {
            return arr[0];
        }

        int mid = size / 2;
        int left = DivideAndConquer(arr.Take(mid).ToArray()) + GetArrayGCD(arr.Skip(mid).ToArray());
        int right = DivideAndConquer(arr.Skip(mid).ToArray()) + GetArrayGCD(arr.Take(mid).ToArray());

        return Math.Max(left, right);
    }

    static int GetGCD(int numA, int numB)
    {
        while (numB > 0)
        {
            (numA, numB) = (numB, numA % numB);
        }

        return numA;
    }

    static int GetArrayGCD(int[] arr)
    {
        int gcd = arr[0];
        int size = arr.Length;

        for (int i = 1; i < size; ++i)
        {
            gcd = GetGCD(gcd, arr[i]);
            if (gcd == 1)
            {
                break;
            }
        }

        return gcd;
    }

    static int DivideAndConquer(int[] arr)
    {
        if (arr.Length < 3)
        {
            return arr.Sum();
        }

        int mid = arr.Length / 2;
        int left = DivideAndConquer(arr.Take(mid).ToArray()) + GetArrayGCD(arr.Skip(mid).ToArray());
        int right = DivideAndConquer(arr.Skip(mid).ToArray()) + GetArrayGCD(arr.Take(mid).ToArray());

        return Math.Max(left, right);
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}