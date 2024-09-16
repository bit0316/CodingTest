public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[][] map;
    static int[,] arr;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());

        SetMap();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new int[size][];
        for (int i = 0; i < size; ++i)
        {
            map[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        }
    }

    static int GetResult()
    {
        int k;

        arr = new int[size, size];
        for (int i = 0; i < size - 1; ++i)
        {
            for (int j = 0; j < size - i - 1; ++j)
            {
                k = i + j + 1;
                arr[j, k] = int.MaxValue;
                for (int l = j; l < k; ++l)
                {
                    arr[j, k] = Math.Min(arr[j, k], arr[j, l] + arr[l + 1, k] + map[j][0] * map[k][1] * map[l][1]);
                }
            }
        }

        return arr[0, size - 1];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}