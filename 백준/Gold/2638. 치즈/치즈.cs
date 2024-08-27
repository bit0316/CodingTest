public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTION = { (-1, 0), (1, 0), (0, -1), (0, 1) };

    static Dictionary<(int, int), int> cheeses;
    static int row;
    static int col;
    static int[][] map;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

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
        cheeses = new Dictionary<(int, int), int>();
        map = new int[row][];

        for (int i = 0; i < row; ++i)
        {
            map[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 0; j < col; ++j)
            {
                if (map[i][j] == 1)
                {
                    cheeses.Add((i, j), 0);
                }
            }
        }
    }

    static int GetResult()
    {
        int time = 0;

        while (cheeses.Count > 0)
        {
            time++;
            BFS(0, 0);
            CheckCheese();
        }

        return time;
    }

    static void BFS(int posX, int posY)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        bool[,] visited = new bool[row, col];
        int curX, curY;
        int x, y;

        queue.Enqueue((posX, posY));
        visited[posX, posY] = true;
        while (queue.Count > 0)
        {
            (x, y) = queue.Dequeue();
            foreach (var dir in DIRECTION)
            {
                curX = x + dir.Item1;
                curY = y + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < row && curY < col && !visited[curX, curY])
                {
                    if (map[curX][curY] == 1)
                    {
                        cheeses[(curX, curY)]++;
                        continue;
                    }
                    queue.Enqueue((curX, curY));
                    visited[curX, curY] = true;
                }
            }
        }
    }

    static void CheckCheese()
    {
        foreach (var cheese in cheeses)
        {
            if (cheese.Value >= 2)
            {
                cheeses.Remove(cheese.Key);
                map[cheese.Key.Item1][cheese.Key.Item2] = 0;
                continue;
            }
            cheeses[cheese.Key] = 0;
        }
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}