public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int MOD = 1000000007;

    static void Main(string[] args)
    {
        int[,,] arr;
        int size;
        int num;

        arr = GetResult();
        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(SR.ReadLine());
            PrintResult(arr[num - 1, 0, 0]);
        }

        SR.Close();
        SW.Close();
    }

    static int[,,] GetResult()
    {
        int[,,] arr = new int[10000, 7, 7];

        for (int i = 0; i < 10000; ++i)
        {
            for (int j = 0; j < 10; ++j)
            {
                if (i == 0 && j == 0)
                {
                    continue;
                }

                if (i == 0)
                {
                    arr[0, j % 7, j % 7] += 1;
                    continue;
                }

                for (int x = 0; x < 7; ++x)
                {
                    for (int y = 0; y < 7; ++y)
                    {
                        arr[i, (x + j) % 7, y * j % 7] += arr[i - 1, x, y];
                        arr[i, (x + j) % 7, y * j % 7] %= MOD;
                    }
                }
            }
        }

        return arr;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}