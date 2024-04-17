public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
    static (int, int, int)[] direction = { (-1, 0, 0), (1, 0, 0), (0, -1, 0), (0, 1, 0), (0, 0, -1), (0, 0, 1) };
    static int[,,] map;
    static int width;
    static int length;
    static int height;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        width = input[0];
        length = input[1];
        height = input[2];

        SetMap();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new int[width, length, height];
        for (int h = 0; h < height; ++h)
        {
            for (int l = 0; l < length; ++l)
            {
                input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
                for (int w = 0; w < width; ++w)
                {
                    map[w, l, h] = input[w];
                    if (map[w, l, h] == 1)
                    {
                        queue.Enqueue((w, l, h));
                    }
                }
            }
        }
    }

    static int GetResult()
    {
        int size;
        int x, y, z;
        int curX, curY, curZ;
        int days = -1;

        while (queue.Count > 0)
        {
            size = queue.Count;
            for (int i = 0; i < size; ++i)
            {
                (x, y, z) = queue.Dequeue();
                foreach (var dir in direction)
                {
                    curX = x + dir.Item1;
                    curY = y + dir.Item2;
                    curZ = z + dir.Item3;
                    if (curX >= 0 && curY >= 0 && curZ >= 0 && curX < width && curY < length && curZ < height
                        && map[curX, curY, curZ] == 0)
                    {
                        queue.Enqueue((curX, curY, curZ));
                        map[curX, curY, curZ] = 1;
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