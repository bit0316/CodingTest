public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Queue<(int, int)> queue = new Queue<(int, int)>();
    static (int, int)[] direction = { (-1, 0), (1, 0), (0, -1), (0, 1) };
    static int[,] map;
    static int width;
    static int length;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        width = input[0];
        length = input[1];

        SetMap();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new int[width, length];
        for (int l = 0; l < length; ++l)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int w = 0; w < width; ++w)
            {
                map[w, l] = input[w];
                if (map[w, l] == 1)
                {
                    queue.Enqueue((w, l));
                }
            }
        }
    }

    static int GetResult()
    {
        int size;
        int x, y;
        int curX, curY;
        int days = -1;

        while (queue.Count > 0)
        {
            size = queue.Count;
            for (int i = 0; i < size; ++i)
            {
                (x, y) = queue.Dequeue();
                foreach (var dir in direction)
                {
                    curX = x + dir.Item1;
                    curY = y + dir.Item2;
                    if (curX >= 0 && curY >= 0 && curX < width && curY < length && map[curX, curY] == 0)
                    {
                        queue.Enqueue((curX, curY));
                        map[curX, curY] = 1;
                    }
                }
            }
            days++;
        }

        return IsValid() ? days : -1;
    }

    static bool IsValid()
    {
        foreach (int pos in map)
        {
            if (pos == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}