public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] direction = { (-1, 0), (1, 0), (0, -1), (0, 1) };
    static Queue<(int, int)> queue = new Queue<(int, int)>();
    static int row;
    static int col;
    static int[] input;
    static int[,] map;
    static int[,] clone;
    static List<(int, int)> empty;
    static List<(int, int)> virus;

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
        map = new int[row, col];
        empty = new List<(int, int)>();
        virus = new List<(int, int)>();
        for (int i = 0; i < row; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 0; j < col; ++j)
            {
                map[i, j] = input[j];
                if (input[j] == 0)
                {
                    empty.Add((i, j));
                }
                if (input[j] == 2)
                {
                    virus.Add((i, j));
                }
            }
        }
    }

    static int GetResult()
    {
        int size = empty.Count;
        int max = 0;

        for (int i = 2; i < size; ++i)
        {
            map[empty[i].Item1, empty[i].Item2] = 1;
            for (int j = 1; j < i; ++j)
            {
                map[empty[j].Item1, empty[j].Item2] = 1;
                for (int k = 0; k < j; ++k)
                {
                    map[empty[k].Item1, empty[k].Item2] = 1;
                    max = Math.Max(max, BFS());
                    map[empty[k].Item1, empty[k].Item2] = 0;
                }
                map[empty[j].Item1, empty[j].Item2] = 0;
            }
            map[empty[i].Item1, empty[i].Item2] = 0;
        }

        return max;
    }

    static int BFS()
    {
        int count = 0;
        int curX, curY;
        int x, y;

        queue.Clear();
        foreach (var pos in virus)
        {
            queue.Enqueue(pos);
        }

        clone = (int[,])map.Clone();
        while (queue.Count > 0)
        {
            (x, y) = queue.Dequeue();
            foreach (var dir in direction)
            {
                curX = x + dir.Item1;
                curY = y + dir.Item2;
                if (curX >= 0 && curX < row && curY >= 0 && curY < col && clone[curX, curY] == 0)
                {
                    queue.Enqueue((curX, curY));
                    clone[curX, curY] = 2;
                }
            }
        }

        foreach (var pos in empty)
        {
            if (clone[pos.Item1, pos.Item2] == 0)
            {
                count++;
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}