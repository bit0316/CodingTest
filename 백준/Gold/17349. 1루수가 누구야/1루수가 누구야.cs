public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int SIZE_MAX = 9;

    static void Main(string[] args)
    {
        int[,] arr;
        int result;

        arr = SetArray();
        result = GetResult(arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[,] SetArray()
    {
        int[,] arr = new int[SIZE_MAX, 2];

        int[] input;
        for (int i = 0; i < SIZE_MAX; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            arr[i, 0] = input[0];
            arr[i, 1] = input[1];
        }

        return arr;
    }

    static int GetResult(int[,] arr)
    {
        int liar = -1;
        int count;

        for (int i = 1; i <= SIZE_MAX; ++i)
        {
            count = 0;
            for (int j = 0; j < SIZE_MAX; ++j)
            {
                if (arr[j, 0] == 1)
                {
                    if (arr[j, 1] != i)
                    {
                        count++;
                    }
                }
                else if (arr[j, 1] == i)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                if (liar != -1)
                {
                    return -1;
                }
                liar = i;
            }
        }

        return liar;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}