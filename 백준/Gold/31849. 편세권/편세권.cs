public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTIONS = { (-1, 0), (1, 0), (0, -1), (0, 1) };

    static (int, int)[] stores;
    static int row;
    static int col;
    static int[,] map;
    static int[] input;

    static void Main(string[] args)
    {
        int house;
        int store;
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];
        house = input[2];
        store = input[3];

        map = new int[row + 1, col + 1];
        SetHouse(house);
        SetStore(store);
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetHouse(int size)
    {
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[input[0], input[1]] = input[2];
        }
    }

    static void SetStore(int size)
    {
        stores = new (int, int)[size];
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            stores[i] = (input[0], input[1]);
        }
    }

    static int GetResult()
    {
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        bool[,] visited = new bool[row + 1, col + 1];
        int curX, curY;
        int x, y, distance;
        int result = int.MaxValue;

        foreach (var store in stores)
        {
            queue.Enqueue((store.Item1, store.Item2, 1));
            visited[store.Item1, store.Item2] = true;
        }

        while (queue.Count > 0)
        {
            (x, y, distance) = queue.Dequeue();
            foreach (var dir in DIRECTIONS)
            {
                curX = x + dir.Item1;
                curY = y + dir.Item2;
                if (curX > 0 && curY > 0 && curX <= row && curY <= col && !visited[curX, curY])
                {
                    if (map[curX, curY] > 0)
                    {
                        result = Math.Min(result, distance * map[curX, curY]);
                    }
                    queue.Enqueue((curX, curY, distance + 1));
                    visited[curX, curY] = true;
                }
            }
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}