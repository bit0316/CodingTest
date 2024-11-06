public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTIONS = { (1, 0), (0, 1) };

    static int[][] map;
    static int row;
    static int col;

    static void Main(string[] args)
    {
        bool result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        col = input[0];
        row = input[1];

        SetMap();
        result = GetResult(0, 0);
        PrintResult(result);

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

    static bool GetResult(int posX, int posY)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        bool[,] visited = new bool[row, col];
        int curX, curY;

        queue.Enqueue((posX, posY));
        visited[posX, posY] = true;
        while (queue.Count > 0)
        {
            (posX, posY) = queue.Dequeue();
            foreach (var dir in DIRECTIONS)
            {
                curX = posX + dir.Item1;
                curY = posY + dir.Item2;
                if (curX < row && curY < col && map[curX][curY] == 1 && !visited[curX, curY])
                {
                    queue.Enqueue((curX, curY));
                    visited[curX, curY] = true;
                }
            }
        }

        return visited[row - 1, col - 1];
    }

    static void PrintResult(bool valid)
    {
        SW.WriteLine(valid ? "Yes" : "No");
    }
}