public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int[,] arr;
    static string strA;
    static string strB;
    static int sizeA;
    static int sizeB;

    static void Main(string[] args)
    {
        strA = SR.ReadLine();
        strB = SR.ReadLine();
        sizeA = strA.Length;
        sizeB = strB.Length;

        GetResult();
        PrintResult(sizeA, sizeB);

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        arr = new int[sizeA + 1, sizeB + 1];
        for (int i = 0; i < sizeA; ++i)
        {
            for (int j = 0; j < sizeB; ++j)
            {
                arr[i + 1, j + 1] = strA[i] == strB[j] ? arr[i, j] + 1 : Math.Max(arr[i, j + 1], arr[i + 1, j]);
            }
        }
    }

    static void PrintResult(int row, int col)
    {
        SW.WriteLine(arr[row, col]);
        PrintLCS(row, col);
    }

    static void PrintLCS(int row, int col)
    {
        if (arr[row, col] == 0)
        {
            return;
        }

        if (strA[row - 1] == strB[col - 1])
        {
            PrintLCS(row - 1, col - 1);
            SW.Write(strA[row - 1]);
        }
        else if (arr[row - 1, col] > arr[row, col - 1])
        {
            PrintLCS(row - 1, col);
        }
        else
        {
            PrintLCS(row, col - 1);
        }
    }
}