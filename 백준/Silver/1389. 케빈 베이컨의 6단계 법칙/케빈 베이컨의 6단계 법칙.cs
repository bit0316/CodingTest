public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_VALUE = 500000;

    static int point;
    static int line;
    static int result;
    static int[,] arr;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];

        InitArray();
        SetArray();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void InitArray()
    {
        arr = new int[point + 1, point + 1];
        for (int i = 1; i <= point; ++i)
        {
            for (int j = 1; j <= point; ++j)
            {
                arr[i, j] = i == j ? 0 : MAX_VALUE;
            }
        }
    }

    static void SetArray()
    {
        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            arr[input[0], input[1]] = 1;
            arr[input[1], input[0]] = 1;
        }

        for (int i = 1; i <= point; ++i)
        {
            for (int j = 1; j <= point; ++j)
            {
                for (int k = 1; k <= point; ++k)
                {
                    if (arr[j, k] > arr[j, i] + arr[i, k])
                    {
                        arr[j, k] = arr[j, i] + arr[i, k];
                    }
                }
            }
        }
    }

    static void GetResult()
    {
        int min = int.MaxValue;
        int index = 0;
        int count;

        for (int i = 1; i <= point; ++i)
        {
            count = 0;
            for (int j = 1; j <= point; ++j)
            {
                count += arr[i, j];
            }
            if (count < min)
            {
                min = count;
                index = i;
            }
        }
        result = index;
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}