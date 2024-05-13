public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int row;
    static int col;
    static int[,] map;
    static int[,] distance;
    static (int, int) start;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
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
        map = new int[row, col];
        distance = new int[row, col];
        for (int i = 0; i < row; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 0; j < col; ++j)
            {
                map[i, j] = input[j];
                if (input[j] == 0)
                {
                    distance[i, j] = 0;
                }
                else if (input[j] == 2)
                {
                    start = (i, j);
                    distance[i, j] = 0;
                }
                else
                {
                    distance[i, j] = -1;
                }
            }
        }
    }

    static void GetResult()
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        (int, int)[] direction = { (-1, 0), (1, 0), (0, -1), (0, 1) };
        (int, int) pos;
        int curX, curY;

        queue.Enqueue(start);
        distance[start.Item1, start.Item2] = 0;
        while (queue.Count > 0)
        {
            pos = queue.Dequeue();
            foreach (var dir in direction)
            {
                curX = pos.Item1 + dir.Item1;
                curY = pos.Item2 + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < row && curY < col && distance[curX, curY] == -1)
                {
                    queue.Enqueue((curX, curY));
                    distance[curX, curY] = distance[pos.Item1, pos.Item2] + 1;
                }
            }
        }
    }

    static void PrintResult()
    {
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                SW.Write($"{distance[i, j]} ");
            }
            SW.WriteLine();
        }
    }
}