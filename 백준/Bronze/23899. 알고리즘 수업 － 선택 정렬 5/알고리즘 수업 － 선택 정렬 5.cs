public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        int[] arrA = SetArray(size);
        int[] arrB = SetArray(size);
        int result;

        result = GetResult(size, arrA, arrB);
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

    static int GetResult(int size, int[] arrA, int[] arrB)
    {
        for (int i = size - 1; i > 0; --i)
        {
            if (IsValid(size, arrA, arrB))
            {
                return 1;
            }

            int max = 0;
            int maxIndex = 0;

            for (int j = 0; j <= i; ++j)
            {
                if (arrA[j] > max)
                {
                    max = arrA[j];
                    maxIndex = j;
                }
            }

            if (maxIndex != i)
            {
                (arrA[maxIndex], arrA[i]) = (arrA[i], arrA[maxIndex]);
            }
        }

        return IsValid(size, arrA, arrB) ? 1 : 0;
    }


    static bool IsValid(int size, int[] arr1, int[] arr2)
    {
        for (int i = 0; i < size; ++i)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }
        return true;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}