public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int MAX_SIZE = 100000;

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            result = GetResult();
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult()
    {
        int[] arr = new int[MAX_SIZE + 1];
        string[] input = SR.ReadLine().Split();
        string strA = input[0];
        string strB = input[1];
        int sizeA = strA.Length;
        int sizeB = strB.Length;
        int count = 0;
        int index;

        index = 0;
        for (int i = 0; i < sizeA; ++i)
        {
            if (strA[i] == 'a')
            {
                arr[index++] = i;
            }
        }

        index = 0;
        for (int i = 0; i < sizeB; ++i)
        {
            if (strB[i] == 'a')
            {
                count += Math.Abs(arr[index++] - i);
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}