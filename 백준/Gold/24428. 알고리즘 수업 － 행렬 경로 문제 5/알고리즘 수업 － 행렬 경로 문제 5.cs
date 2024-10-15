public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int LIMIT_POINT = 3;

    static HashSet<(int, int)> points = new HashSet<(int, int)>();
    static int[,,] arr;
    static int[,] map;
    static int size;
    static int count;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());
        SetMap(size);

        count = int.Parse(SR.ReadLine());
        SetPoint(count);

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap(int size)
    {
        string[] input;

        map = new int[size + 1, size + 1];
        for (int i = 1; i <= size; ++i)
        {
            input = SR.ReadLine().Split();
            for (int j = 1; j <= size; ++j)
            {
                map[i, j] = int.Parse(input[j - 1]);
            }
        }
    }

    static void SetPoint(int count)
    {
        int[] input;

        for (int i = 0; i < count; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            points.Add((input[0], input[1]));
        }
    }

    static int GetResult()
    {
        int max;

        arr = new int[size + 1, size + 1, 4];
        for (int i = 1; i <= size; ++i)
        {
            for (int j = 1; j <= size; ++j)
            {
                arr[i, j, 0] = Math.Max(arr[i - 1, j, 0], arr[i, j - 1, 0]) + map[i, j];
                for (int k = 1; k <= LIMIT_POINT; ++k)
                {
                    arr[i, j, k] = Math.Max(arr[i - 1, j, k], arr[i, j - 1, k]);
                    if (arr[i, j, k] > 0)
                    {
                        arr[i, j, k] += map[i, j];
                    }
                }

                for (int k = LIMIT_POINT; k > 0; --k)
                {
                    if (points.Contains((i, j)))
                    {
                        max = arr[i, j, k - 1] - map[i, j];
                        if (max > 0)
                        {
                            arr[i, j, k] = Math.Max(arr[i, j, k], max + map[i, j]);
                        }
                    }
                }
            }
        }

        return arr[size, size, LIMIT_POINT] > 0 ? arr[size, size, LIMIT_POINT] : -1;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}