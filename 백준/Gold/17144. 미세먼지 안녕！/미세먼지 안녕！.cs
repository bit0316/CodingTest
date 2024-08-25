public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTION = { (-1, 0), (0, 1), (1, 0), (0, -1) };

    static Queue<(int, int, int)> dust = new Queue<(int, int, int)>();
    static (int, int)[] cleaner;
    static int row;
    static int col;
    static int time;
    static int[][] map;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];
        time = input[2];

        SetMap();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        int index = 0;

        cleaner = new (int, int)[2];
        map = new int[row][];
        for (int i = 0; i < row; ++i)
        {
            map[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (map[i].Contains(-1))
            {
                cleaner[index++] = (i, 0);
            }
        }
    }

    static int GetResult()
    {
        int sum = 0;

        CheckDust();
        for (int i = 0; i < time; ++i)
        {
            SpreadDust();
            CleanDust();
            CheckDust();
        }

        for (int i = 0; i < row; ++i)
        {
            sum += map[i].Sum();
        }
        sum += 2;

        return sum;
    }

    static void SpreadDust()
    {
        int posX, posY, size;
        int curX, curY;
        int count;

        while (dust.Count > 0)
        {
            count = 0;
            (posX, posY, size) = dust.Dequeue();
            foreach (var dir in DIRECTION)
            {
                curX = posX + dir.Item1;
                curY = posY + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < row && curY < col && map[curX][curY] != -1)
                {
                    count++;
                    map[curX][curY] += size / 5;
                }
            }
            map[posX][posY] -= size / 5 * count;
        }
    }

    static void CleanDust()
    {
        int curX, curY;
        int posX;

        (curX, curY) = cleaner[0];
        posX = curX;
        foreach (var dir in DIRECTION)
        {
            curX += dir.Item1;
            curY += dir.Item2;
            while (curX >= 0 && curY >= 0 && curX <= posX && curY < col)
            {
                map[curX - dir.Item1][curY - dir.Item2] = map[curX][curY];
                curX += dir.Item1;
                curY += dir.Item2;
            }
            curX -= dir.Item1;
            curY -= dir.Item2;
        }
        map[cleaner[0].Item1][cleaner[0].Item2 + 1] = 0;
        map[cleaner[0].Item1][cleaner[0].Item2] = -1;

        (curX, curY) = cleaner[1];
        posX = curX;
        foreach (var dir in DIRECTION)
        {
            curX -= dir.Item1;
            curY += dir.Item2;
            while (curX >= posX && curY >= 0 && curX < row && curY < col)
            {
                map[curX + dir.Item1][curY - dir.Item2] = map[curX][curY];
                curX -= dir.Item1;
                curY += dir.Item2;
            }
            curX += dir.Item1;
            curY -= dir.Item2;
        }
        map[cleaner[1].Item1][cleaner[1].Item2 + 1] = 0;
        map[cleaner[1].Item1][cleaner[1].Item2] = -1;
    }

    static void CheckDust()
    {
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (map[i][j] > 0)
                {
                    dust.Enqueue((i, j, map[i][j]));
                }
            }
        }
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}