public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTION = { (-1, 0), (0, -1), (0, 1), (1, 0) };

    static (int, int) sharkPos;
    static int sharkLevel;
    static int sharkExp;
    static int size;
    static int[][] map;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());

        SetMap();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new int[size][];
        for (int i = 0; i < size; ++i)
        {
            map[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 0; j < size; ++j)
            {
                if (map[i][j] == 9)
                {
                    sharkPos = (i, j);
                    sharkLevel = 2;
                    sharkExp = 0;
                }
            }
        }
    }

    static int GetResult()
    {
        int sum = 0;
        int time;

        time = BFS(sharkPos.Item1, sharkPos.Item2);
        while (time > 0)
        {
            sum += time;
            if (sharkExp == sharkLevel)
            {
                sharkLevel++;
                sharkExp = 0;
            }
            time = BFS(sharkPos.Item1, sharkPos.Item2);
        }

        return sum;
    }

    static int BFS(int posX, int posY)
    {
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        List<(int, int)> list = new List<(int, int)>();
        bool[,] visited = new bool[size, size];
        int min = int.MaxValue;
        int time = 0;
        int curX, curY;
        int x, y;

        map[posX][posY] = 0;
        queue.Enqueue((posX, posY, time));
        visited[posX, posY] = true;
        while (queue.Count > 0)
        {
            (x, y, time) = queue.Dequeue();
            if (time == min)
            {
                break;
            }

            foreach (var dir in DIRECTION)
            {
                curX = x + dir.Item1;
                curY = y + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < size && curY < size &&
                    map[curX][curY] <= sharkLevel && !visited[curX, curY])
                {
                    if (map[curX][curY] != 0 && map[curX][curY] < sharkLevel)
                    {
                        min = Math.Min(min, time + 1);
                        list.Add((curX, curY));
                    }
                    queue.Enqueue((curX, curY, time + 1));
                    visited[curX, curY] = true;
                }
            }
        }

        if (list.Count > 0)
        {
            sharkPos = list.OrderBy(x => x.Item1).ThenBy(y => y.Item2).ToList()[0];
            map[sharkPos.Item1][sharkPos.Item2] = 0;
            sharkExp++;

            return time;
        }

        return 0;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}