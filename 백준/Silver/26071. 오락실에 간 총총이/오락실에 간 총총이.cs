public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static char[][] map;
    static int size;
    static int left, right;
    static int up, down;

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
        map = new char[size][];
        for (int i = 0; i < size; ++i)
        {
            map[i] = SR.ReadLine().ToArray();
        }
    }

    static int GetResult()
    {
        left = size;
        right = -1;
        up = size;
        down = -1;

        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                if (map[i][j] == 'G')
                {
                    left = Math.Min(left, j);
                    right = Math.Max(right, j);
                    up = Math.Min(up, i);
                    down = Math.Max(down, i);
                }
            }
        }

        if (left == right && up == down)
        {
            return 0;
        }
        if (left == right)
        {
            return Math.Min(size - up - 1, down);
        }
        if (up == down)
        {
            return Math.Min(size - left - 1, right);
        }
        return Math.Min(size - left - 1, right) + Math.Min(size - up - 1, down);
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}