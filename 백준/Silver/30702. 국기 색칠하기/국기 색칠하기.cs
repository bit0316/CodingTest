public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTIONS = { (0, -1), (0, 1), (-1, 0), (1, 0) };
    static int index = 0;
    static int row;
    static int col;

    static void Main(string[] args)
    {
        int[] input;
        int[,] gonfalonA;
        int[,] gonfalonB;
        bool valid;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];

        gonfalonA = SetGonfalon(row, col);
        gonfalonB = SetGonfalon(row, col);
        valid = IsValid(row, col, gonfalonA, gonfalonB);
        PrintResult(valid);

        SR.Close();
        SW.Close();
    }

    static int[,] SetGonfalon(int row, int col)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int[,] gonfalon = new int[row, col];
        string input;

        for (int i = 0; i < row; ++i)
        {
            input = SR.ReadLine();
            for (int j = 0; j < col; ++j)
            {
                if (!dict.ContainsKey(input[j]))
                {
                    dict[input[j]] = ++index;
                }
                gonfalon[i, j] = dict[input[j]];
            }
        }

        return gonfalon;
    }

    static bool IsValid(int row, int col, int[,] gonfalonA, int[,] gonfalonB)
    {
        bool[,] visited = new bool[row, col];

        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (gonfalonA[i, j] == gonfalonB[i, j])
                {
                    visited[i, j] = true;
                    continue;
                }

                if (visited[i, j] || !TryPaintGonfalon(i, j, gonfalonB[i, j], gonfalonA, visited))
                {
                    return false;
                }
            }
        }
        return true;
    }

    static bool TryPaintGonfalon(int posX, int posY, int paint, int[,] gonfalon, bool[,] visited)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        int curX, curY;
        int original;

        original = gonfalon[posX, posY];
        queue.Enqueue((posX, posY));
        gonfalon[posX, posY] = paint;
        visited[posX, posY] = true;
        while (queue.Count > 0)
        {
            (posX, posY) = queue.Dequeue();
            foreach (var dir in DIRECTIONS)
            {
                curX = posX + dir.Item1;
                curY = posY + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < row && curY < col && gonfalon[curX, curY] == original)
                {
                    if (visited[curX, curY])
                    {
                        return false;
                    }
                    queue.Enqueue((curX, curY));
                    gonfalon[posX, posY] = paint;
                    visited[posX, posY] = true;
                }
            }
        }
        return true;
    }

    static void PrintResult(bool valid)
    {
        SW.WriteLine(valid ? "YES" : "NO");
    }
}