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
        int max = 0;

        arr = new int[size, size];
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                for (int x = 0; x <= i; ++x)
                {
                    for (int y = 0; y <= j; ++y)
                    {
                        if (map[x][y] < map[i][j])
                        {
                            arr[i, j] = Math.Max(arr[i, j], arr[x, y] + 1);
                        }
                    }
                }
            }
        }

        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                if (max < arr[i, j])
                {
                    max = arr[i, j];
                }
            }
        }

        return max + 1;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}