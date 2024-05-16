public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int row;
    static int col;
    static int[,] map;
    static (int, int) start;
    static string[] input;

    static void Main(string[] args)
    {
        int count;

        input = SR.ReadLine().Split();
        row = int.Parse(input[0]);
        col = int.Parse(input[1]);

        SetMap();
        count = GetCount();
        PrintResult(count);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new int[row, col];
        for (int i = 0; i < row; ++i)
        {
            input = SR.ReadLine().Split();
            for (int j = 0; j < col; ++j)
            {
                map[i, j] = input[0][j];
                if (input[0][j] == 'I')
                {
                    start = (i, j);
                }
            }
        }
    }

    static int GetCount()
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        (int, int)[] direction = { (-1, 0), (1, 0), (0, -1), (0, 1) };
        (int, int) pos;
        int curX, curY;
        int count = 0;

        queue.Enqueue(start);
        while (queue.Count > 0)
        {
            pos = queue.Dequeue();
            foreach (var dir in direction)
            {
                curX = pos.Item1 + dir.Item1;
                curY = pos.Item2 + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < row && curY < col && map[curX, curY] != 'X')
                {
                    queue.Enqueue((curX, curY));
                    if (map[curX, curY] == 'P')
                    {
                        count++;
                    }
                    map[curX, curY] = 'X';
                }
            }
        }

        return count;
    }

    static void PrintResult(int count)
    {
        if (count == 0)
        {
            SW.WriteLine("TT");
        }
        else
        {
            SW.WriteLine(count);
        }
    }
}