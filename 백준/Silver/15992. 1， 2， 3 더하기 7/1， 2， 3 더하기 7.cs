public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int MAX_SIZE = 1000;
    const int MOD_SIZE = 1000000009;

    static void Main(string[] args)
    {
        int size;
        int[,] arr;
        int[] input;

        arr = SetArray(MAX_SIZE);

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            SW.WriteLine(arr[input[0], input[1]]);
        }

        SR.Close();
        SW.Close();
    }

    static int[,] SetArray(int size)
    {
        int[,] arr = new int[MAX_SIZE + 4, MAX_SIZE + 4];

        arr[0, 0] = 1;
        for (int i = 1; i <= MAX_SIZE; ++i)
        {
            for (int j = 1; j <= i; ++j)
            {
                if (i >= 1)
                {
                    arr[i, j] = (arr[i, j] + arr[i - 1, j - 1]) % MOD_SIZE;
                }

                if (i >= 2)
                {
                    arr[i, j] = (arr[i, j] + arr[i - 2, j - 1]) % MOD_SIZE;
                }

                if (i >= 3)
                {
                    arr[i, j] = (arr[i, j] + arr[i - 3, j - 1]) % MOD_SIZE;
                }
            }
        }

        return arr;
    }
}