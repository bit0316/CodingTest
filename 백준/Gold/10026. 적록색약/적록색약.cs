public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTION = { (-1, 0), (1, 0), (0, -1), (0, 1) };
    static int RED = 0;
    static int GREEN = 1;
    static int BLUE = 2;

    static int size;
    static int[,] color;
    static bool[,] visited;

    static void Main(string[] args)
    {
        int rgb;
        int rb;

        size = int.Parse(SR.ReadLine());

        SetColor();
        rgb = GetResult();
        ChangeColor(GREEN, RED);
        rb = GetResult();
        PrintResult(rgb, rb);

        SR.Close();
        SW.Close();
    }

    static void SetColor()
    {
        string input;

        color = new int[size, size];
        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine();
            for (int j = 0; j < size; ++j)
            {
                if (input[j] == 'G')
                {
                    color[i, j] = GREEN;
                }
                else if (input[j] == 'B')
                {
                    color[i, j] = BLUE;
                }
            }
        }
    }

    static void ChangeColor(int from, int to)
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                if (color[i, j] == from)
                {
                    color[i, j] = to;
                }
            }
        }
    }

    static int GetResult()
    {
        int count = 0;

        visited = new bool[size, size];
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                if (!visited[i, j])
                {
                    DFS(i, j);
                    count++;
                }
            }
        }

        return count;
    }

    static void DFS(int row, int col)
    {
        Stack<(int, int)> stack = new Stack<(int, int)>();
        (int, int) pos;
        int curX, curY;
        int rgb;

        rgb = color[row, col];
        stack.Push((row, col));
        visited[row, col] = true;
        while (stack.Count > 0)
        {
            pos = stack.Pop();
            foreach (var dir in DIRECTION)
            {
                curX = pos.Item1 + dir.Item1;
                curY = pos.Item2 + dir.Item2;

                if (curX >= 0 && curY >= 0 && curX < size && curY < size
                    && !visited[curX, curY] && color[curX, curY] == rgb)
                {
                    stack.Push((curX, curY));
                    visited[curX, curY] = true;
                }
            }
        }
    }

    static void PrintResult(int rgb, int rb)
    {
        SW.WriteLine($"{rgb} {rb}");
    }
}