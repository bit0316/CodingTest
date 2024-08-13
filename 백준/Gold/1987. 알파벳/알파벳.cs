public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_CHAR = 26;
    static (int, int)[] DIRECTION = { (-1, 0), (1, 0), (0, -1), (0, 1) };
    
    static int row;
    static int col;
    static int result;
    static char[,] map;
    static bool[] visited;

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];

        SetMap();
        GetResult(0, 0);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        string input;

        map = new char[row, col];
        for (int i = 0; i < row; ++i)
        {
            input = SR.ReadLine();
            for (int j = 0; j < col; ++j)
            {
                map[i, j] = input[j];
            }
        }
    }

    static void GetResult(int posX, int posY)
    {
        result = 0;
        visited = new bool[MAX_CHAR];

        visited[map[posX, posY] - 'A'] = true;
        DFS(posX, posY, 1);
    }

    static void DFS(int posX, int posY, int count)
    {
        if (result < count)
        {
            result = count;
        }

        int curX, curY;

        foreach (var dir in DIRECTION)
        {
            curX = posX + dir.Item1;
            curY = posY + dir.Item2;
            if (curX >= 0 && curY >= 0 && curX < row && curY < col &&
                !visited[map[curX, curY] - 'A'])
            {
                visited[map[curX, curY] - 'A'] = true;
                DFS(curX, curY, count + 1);
                visited[map[curX, curY] - 'A'] = false;
            }
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}