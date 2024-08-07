public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] nums;
    static int[] arrA;
    static int[] arrB;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());
        nums = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        SetArray();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        arrA = new int[size];
        for (int i = 0; i < size; ++i)
        {
            arrA[i] = 1;
            for (int j = 0; j < i; ++j)
            {
                if (nums[i] > nums[j] && arrA[i] < arrA[j] + 1)
                {
                    arrA[i] = arrA[j] + 1;
                }
            }
        }

        arrB = new int[size];
        for (int i = size - 1; i >= 0; --i)
        {
            arrB[i] = 1;
            for (int j = size - 1; j >= i; --j)
            {
                if (nums[i] > nums[j] && arrB[i] < arrB[j] + 1)
                {
                    arrB[i] = arrB[j] + 1;
                }
            }
        }
    }

    static int GetResult()
    {
        int result = 0;

        for (int i = 0; i < size; ++i)
        {
            if (result < arrA[i] + arrB[i] - 1)
            {
                result = arrA[i] + arrB[i] - 1;
            }
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}