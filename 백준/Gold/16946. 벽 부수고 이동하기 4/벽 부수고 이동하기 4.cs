public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTIONS = { (-1, 0), (1, 0), (0, -1), (0, 1) };

    static Queue<(int, int)> walls = new Queue<(int, int)>();
    static List<int> counts = new List<int>();
    static int[,] map;
    static int[,] group;
    static int row;
    static int col;

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
        string input;

        map = new int[row, col];
        group = new int[row, col];
        for (int i = 0; i < row; ++i)
        {
            input = SR.ReadLine();
            for (int j = 0; j < col; ++j)
            {
                map[i, j] = int.Parse(input[j].ToString());
                if (map[i, j] == 1)
                {
                    walls.Enqueue((i, j));
                    group[i, j] = -1;
                }
            }
        }
    }

    static void GetResult()
    {
        int posX, posY;
        int curX, curY;
        int index;
        bool[] visited;

        index= 0;
        counts.Clear();
        counts.Add(0);
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (group[i, j] == 0)
                {
                    index++;
                    BFS(index, i, j);
                }
            }
        }

        while (walls.Count > 0)
        {
            visited = new bool[index + 1];
            (posX, posY) = walls.Dequeue();
            foreach (var dir in DIRECTIONS)
            {
                curX = posX + dir.Item1;
                curY = posY + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < row && curY < col &&
                    group[curX, curY] != -1 && !visited[group[curX, curY]])
                {
                    map[posX, posY] += counts[group[curX, curY]];
                    visited[group[curX, curY]] = true;
                }
            }
            map[posX, posY] %= 10;
        }
    }

    static void BFS(int index, int posX, int posY)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        int curX, curY;
        int count = 1;

        queue.Enqueue((posX, posY));
        group[posX, posY] = index;
        while (queue.Count > 0)
        {
            (posX, posY) = queue.Dequeue();
            foreach (var dir in DIRECTIONS)
            {
                curX = posX + dir.Item1;
                curY = posY + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < row && curY < col && group[curX, curY] == 0)
                {
                    queue.Enqueue((curX, curY));
                    group[curX, curY] = index;
                    count++;
                }
            }
        }
        counts.Add(count);
    }

    static void PrintResult()
    {
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                SW.Write(map[i, j]);
            }
            SW.WriteLine();
        }
    }
}