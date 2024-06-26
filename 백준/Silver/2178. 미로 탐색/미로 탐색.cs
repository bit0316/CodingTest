public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int row;
    static int col;
    static int[,] map;
    static string[] input;

    static void Main(string[] args)
    {
        input = SR.ReadLine().Split();
        row = int.Parse(input[0]);
        col = int.Parse(input[1]);

        SetMap();
        GetResult(1, 1);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new int[row + 1, col + 1];
        for (int i = 1; i <= row; ++i)
        {
            input = SR.ReadLine().Split();
            for (int j = 1; j <= col; ++j)
            {
                map[i, j] = int.Parse(input[0][j - 1].ToString());
            }
        }
    }

    static void GetResult(int startX, int startY)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        (int, int)[] direction = { (-1, 0), (1, 0), (0, -1), (0, 1) };
        (int, int) pos;
        int curX, curY;

        queue.Enqueue((startX, startY));
        while (queue.Count > 0)
        {
            pos = queue.Dequeue();
            foreach (var dir in direction)
            {
                curX = pos.Item1 + dir.Item1;
                curY = pos.Item2 + dir.Item2;
                if (curX > 0 && curY > 0 && curX <= row && curY <= col && map[curX, curY] == 1)
                {
                    queue.Enqueue((curX, curY));
                    map[curX, curY] += map[pos.Item1, pos.Item2];
                }
            }
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(map[row, col]);
    }
}