public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static long times;
    static long[,] mtrx;
    static long[,] result;

    static void Main(string[] args)
    {
        string[] input = SR.ReadLine().Split();
        size = int.Parse(input[0]);
        times = long.Parse(input[1]);

        SetMatrix();
        GetResult();
        PrintMatrix();

        SR.Close();
        SW.Close();
    }

    static void SetMatrix()
    {
        string[] input;

        mtrx = new long[size, size];
        result = new long[size, size];
        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();

            result[i, i] = 1;
            for (int j = 0; j < size; ++j)
            {
                mtrx[i, j] = long.Parse(input[j]);
            }
        }
    }

    static void GetResult()
    {
        while (times > 0)
        {
            if (times % 2 == 1)
            {
                MultiMatrix(result, mtrx);
            }
            MultiMatrix(mtrx, mtrx);
            times /= 2;
        }
    }

    static void MultiMatrix(long[,] mtrxA, long[,] mtrxB)
    {
        long[,] temp = new long[size, size];

        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                for (int k = 0; k < size; ++k)
                {
                    temp[i, j] += (mtrxA[i, k] * mtrxB[k, j]);
                }

                temp[i, j] %= 1000;
            }
        }

        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                mtrxA[i, j] = temp[i, j];
            }
        }
    }

    static void PrintMatrix()
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                SW.Write($"{result[i, j]} ");
            }
            SW.WriteLine();
        }
    }
}