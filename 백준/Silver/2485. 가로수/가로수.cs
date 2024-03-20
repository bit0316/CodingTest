public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] trees;
        int[] lengths;

        size = int.Parse(SR.ReadLine());
        trees = new int[size];

        SetArray(trees, size);
        lengths = GetLength(trees);
        PrintResult(trees, lengths);

        SR.Close();
        SW.Close();
    }

    static void SetArray(int[] arr, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }
    }

    static int[] GetLength(int[] arr)
    {
        int size = arr.Length;
        int[] result = new int[size - 1];

        for (int i = 0; i < size - 1; ++i)
        {
            result[i] = arr[i + 1] - arr[i];
        }

        return result.OrderBy(x => x).ToArray();
    }

    static int GetCount(int[] arrA, int[] arrB)
    {
        int size = arrA.Length - 1;
        int maxLength = arrA[size] - arrA[0];
        int minLength = GetGCD(arrB[1], arrB[0]);

        for (int i = 1; i < size - 1; ++i)
        {
            minLength = GetGCD(arrB[i + 1], minLength);
            if (minLength == 1)
            {
                break;
            }
        }

        return maxLength / minLength - size;
    }

    static int GetGCD(int numA, int numB)
    {
        int remain = numA % numB;

        return remain != 0 ? GetGCD(numB, remain) : numB;
    }

    static void PrintResult(int[] arrA, int[] arrB)
    {
        SW.WriteLine(GetCount(arrA, arrB));

        SW.Flush();
    }
}