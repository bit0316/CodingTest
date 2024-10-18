public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int DIV_SIZE = 1000000007;
    const int POINT_SIZE = 8;

    static long[,] arr = new long[,]
    {
        {0, 1, 1, 0, 0, 0, 0, 0},
        {1, 0, 1, 1, 0, 0, 0, 0},
        {1, 1, 0, 1, 1, 0, 0, 0},
        {0, 1, 1, 0, 1, 1, 0, 0},
        {0, 0, 1, 1, 0, 1, 0, 1},
        {0, 0, 0, 1, 1, 0, 1, 0},
        {0, 0, 0, 0, 0, 1, 0, 1},
        {0, 0, 0, 0, 1, 0, 1, 0}
    };

    static void Main(string[] args)
    {
        int num;
        long result;

        num = int.Parse(SR.ReadLine());

        result = GetResult(num);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult(int num)
    {
        long[,] result = new long[POINT_SIZE, POINT_SIZE];
        long[,] copy = DeepCopy(arr);

        for (int i = 0; i < 8; ++i)
        {
            result[i, i] = 1;
        }

        while (num > 0)
        {
            if (num % 2 == 1)
            {
                result = Multiply(result, copy);
                num -= 1;
            }
            copy = Multiply(copy, copy);
            num /= 2;
        }

        return result[0, 0];
    }

    static long[,] DeepCopy(long[,] arr)
    {
        int row = arr.GetLength(0);
        int col = arr.GetLength(1);
        long[,] copy = new long[row, col];

        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                copy[i, j] = arr[i, j];
            }
        }

        return copy;
    }

    static long[,] Multiply(long[,] arrA, long[,] arrB)
    {
        long[,] arrMult;
        long count;

        arrMult = new long[POINT_SIZE, POINT_SIZE];
        for (int i = 0; i < POINT_SIZE; ++i)
        {
            for (int j = 0; j < POINT_SIZE; ++j)
            {
                count = 0;
                for (int k = 0; k < POINT_SIZE; ++k)
                {
                    count += arrA[i, k] * arrB[k, j] % DIV_SIZE;
                    count %= DIV_SIZE;
                }
                arrMult[i, j] = count % DIV_SIZE;
            }
        }
        return arrMult;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}