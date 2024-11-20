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
        int count = 0;

        for (int i = 0; i < size - 1; ++i)
        {
            if (arrA[i] != arrB[i])
            {
                count++;
                arrA[i + 1] ^= arrA[i] ^ arrB[i];
            }
        }

        return arrA[size - 1] == arrB[size - 1] ? count : -1;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}