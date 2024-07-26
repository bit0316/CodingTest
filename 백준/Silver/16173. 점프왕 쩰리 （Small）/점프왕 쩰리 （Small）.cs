public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Queue<(int, int)> queue = new Queue<(int, int)>();
    static (int, int)[] direction = { (0, 1), (1, 0) };
    static int[,] map;
    static int size;

    static void Main(string[] args)
    {
        bool result;

        size = int.Parse(SR.ReadLine());

        SetMap();
        result = GetResult(0, 0);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        string[] input;

        map = new int[size, size];
        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            for (int j = 0; j < size; ++j)
            {
                map[i, j] = int.Parse(input[j]);
            }
        }
    }

    static bool GetResult(int posX, int posY)
    {
        int curX, curY;
        int x, y;
        queue.Clear();

        queue.Enqueue((posX, posY));
        while (queue.Count > 0)
        {
            (x, y) = queue.Dequeue();
            if (map[x, y] == -1)
            {
                return true;
            }

            foreach (var dir in direction)
            {
                curX = x + dir.Item1 * map[x, y];
                curY = y + dir.Item2 * map[x, y];
                if (curX < size && curY < size && map[curX, curY] != 0)
                {
                    queue.Enqueue((curX, curY));
                }
            }
        }

        return false;
    }

    static void PrintResult(bool result)
    {
        if (result)
        {
            SW.WriteLine("HaruHaru");
        }
        else
        {
            SW.WriteLine("Hing");
        }
    }
}