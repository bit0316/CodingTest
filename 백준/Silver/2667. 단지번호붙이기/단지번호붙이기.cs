public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[,] map;
    static List<int> list = new List<int>();
    static string[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        SetMap();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new int[size, size];
        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            for (int j = 0; j < size; ++j)
            {
                map[i, j] = int.Parse(input[0][j].ToString());
            }
        }
    }

    static void GetResult()
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                GetCount(i, j);
            }
        }
        list.Sort();
    }

    static void GetCount(int startX, int startY)
    {
        if (map[startX, startY] != 1)
        {
            return;
        }

        Queue<(int, int)> queue = new Queue<(int, int)>();
        (int, int)[] direction = { (-1, 0), (1, 0), (0, -1), (0, 1) };
        (int, int) pos;
        int curX, curY;
        int count = 1;

        map[startX, startY]++;
        queue.Enqueue((startX, startY));
        while (queue.Count > 0)
        {
            pos = queue.Dequeue();
            foreach (var dir in direction)
            {
                curX = pos.Item1 + dir.Item1;
                curY = pos.Item2 + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < size && curY < size && map[curX, curY] == 1)
                {
                    count++;
                    map[curX, curY]++;
                    queue.Enqueue((curX, curY));
                }
            }
        }

        list.Add(count);
    }

    static void PrintResult()
    {
        SW.WriteLine(list.Count);
        foreach (var count in list)
        {
            SW.WriteLine(count);
        }
    }
}