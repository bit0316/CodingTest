public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] direction = { (-1, 0), (1, 0), (0, -1), (0, 1) };
    static int row;
    static int col;
    static int max;
    static int[][] map;
    static bool[,] visited;

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];

        SetMap();
        GetResult();
        PrintResult();

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

    static void GetResult()
    {
        max = 0;
        visited = new bool[row, col];
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                ShapeDefault(i, j, 0, 0);
                ShapeT(i, j);
            }
        }
    }

    static void ShapeDefault(int posX, int posY, int sum, int count)
    {
        if (count == 4)
        {
            max = Math.Max(max, sum);
            return;
        }

        int curX, curY;

        foreach (var dir in direction)
        {
            curX = posX + dir.Item1;
            curY = posY + dir.Item2;
            if (curX >= 0 && curY >= 0 && curX < row && curY < col && !visited[curX, curY])
            {
                visited[curX, curY] = true;
                ShapeDefault(curX, curY, sum + map[curX][curY], count + 1);
                visited[curX, curY] = false;
            }
        }
    }

    static void ShapeT(int posX, int posY)
    {
        int sum;

        if (posX >= 1 && posY >= 0 && posX < row - 1 && posY < col - 1)
        {
            sum = map[posX][posY + 1] + map[posX - 1][posY] + map[posX][posY] + map[posX + 1][posY];
            max = Math.Max(max, sum);
        }
        if (posX >= 0 && posY >= 1 && posX < row - 1 && posY < col - 1)
        {
            sum = map[posX][posY + 1] + map[posX][posY] + map[posX + 1][posY] + map[posX][posY - 1];
            max = Math.Max(max, sum);
        }
        if (posX >= 1 && posY >= 1 && posX < row - 1 && posY < col)
        {
            sum = map[posX - 1][posY] + map[posX][posY] + map[posX + 1][posY] + map[posX][posY - 1];
            max = Math.Max(max, sum);
        }
        if (posX >= 1 && posY >= 1 && posX < row && posY < col - 1)
        {
            sum = map[posX][posY + 1] + map[posX - 1][posY] + map[posX][posY] + map[posX][posY - 1];
            max = Math.Max(max, sum);
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(max);
    }
}