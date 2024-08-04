public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] direction = { (-1, 0), (1, 0), (0, -1), (0, 1) };
    static int row;
    static int col;
    static char[][] map;
    static bool[,] visited;

    static void Main(string[] args)
    {
        int white, blue;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        col = input[0];
        row = input[1];

        SetMap();
        white = GetResult('W');
        blue = GetResult('B');
        PrintResult(white, blue);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new char[row][];
        for (int i = 0; i < row; ++i)
        {
            map[i] = SR.ReadLine().ToArray();
        }
    }

    static int GetResult(char color)
    {
        int power = 0;

        visited = new bool[row, col];
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (!visited[i, j] && map[i][j] == color)
                {
                    power += (int)Math.Pow(BFS(i, j, color), 2);
                }
            }
        }

        return power;
    }

    static int BFS(int posX, int posY, char color)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        int curX, curY;
        int x, y;
        int count = 1;

        queue.Enqueue((posX, posY));
        visited[posX, posY] = true;
        while (queue.Count > 0)
        {
            (x, y) = queue.Dequeue();
            foreach (var dir in direction)
            {
                curX = x + dir.Item1;
                curY = y + dir.Item2;
                if (curX >= 0 && curX < row && curY >= 0 && curY < col &&
                    !visited[curX, curY] && map[curX][curY] == color)
                {
                    queue.Enqueue((curX, curY));
                    visited[curX, curY] = true;
                    count++;
                }
            }
        }

        return count;
    }

    static void PrintResult(int white, int blue)
    {
        SW.WriteLine($"{white} {blue}");
    }
}