public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
    static (int, int)[] direction = { (-1, 0), (1, 0), (0, -1), (0, 1) };
    static int row;
    static int col;
    static int[,] map;
    static int[,,] cost;

    static void Main(string[] args)
    {
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];

        SetMap();
        result = BFS(0, 0);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        string input;

        map = new int[row, col];
        for (int i = 0; i < row; ++i)
        {
            input = SR.ReadLine();
            for (int j = 0; j < col; ++j)
            {
                map[i, j] = int.Parse(input[j].ToString());
            }
        }
    }

    static int BFS(int startX, int startY)
    {
        int curX, curY;
        int posX, posY, wall;

        queue.Clear();
        cost = new int[row, col, 2];

        queue.Enqueue((startX, startY, 0));
        cost[startX, startY, 0] = 1;
        while (queue.Count > 0)
        {
            (posX, posY, wall) = queue.Dequeue();
            if (posX == row - 1 && posY == col - 1)
            {
                return cost[posX, posY, wall];
            }

            foreach (var dir in direction)
            {
                curX = posX + dir.Item1;
                curY = posY + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < row && curY < col)
                {
                    if (map[curX, curY] == 1 && wall == 0)
                    {
                        queue.Enqueue((curX, curY, 1));
                        cost[curX, curY, 1] = cost[posX, posY, 0] + 1;
                    }
                    else if (map[curX, curY] == 0 && cost[curX, curY, wall] == 0)
                    {
                        queue.Enqueue((curX, curY, wall));
                        cost[curX, curY, wall] = cost[posX, posY, wall] + 1;
                    }
                }
            }
        }

        return -1;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}