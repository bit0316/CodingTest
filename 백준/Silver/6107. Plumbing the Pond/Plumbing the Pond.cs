public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int row;
    static int col;
    static int[][] map;

    static void Main(string[] args)
    {
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];

        SetMap();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new int[row][];
        for (int i = 0; i < row; ++i)
        {
            map[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        }
    }

    static int GetResult()
    {
        int depth = 0;

        for (int i = 1; i < row; ++i)
        {
            if (map[i][0] == map[i - 1][0])
            {
                depth = Math.Max(depth, map[i][0]);
            }
        }

        for (int i = 1; i < col; ++i)
        {
            if (map[0][i] == map[0][i - 1])
            {
                depth = Math.Max(depth, map[0][i]);
            }
        }

        for (int i = 1; i < row; ++i)
        {
            for (int j = 1; j < col; ++j)
            {
                if (map[i][j] == map[i - 1][j] || map[i][j] == map[i][j - 1] || map[i][j] == map[i - 1][j - 1])
                {
                    depth = Math.Max(depth, map[i][j]);
                }
                else if (map[i - 1][j] == map[i][j - 1])
                {
                    depth = Math.Max(depth, map[i - 1][j]);
                }
            }
        }

        return depth;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}