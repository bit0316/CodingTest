public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int count;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            count = GetCountEarthworm();
            PrintResult(count);
        }

        SR.Close();
        SW.Close();
    }

    static int GetCountEarthworm()
    {
        bool[,] isCabbage;
        bool[,] isCheck;
        int row;
        int col;
        int posX;
        int posY;
        int size;
        int count = 0;
        string[] input;

        input = SR.ReadLine().Split();
        row = int.Parse(input[0]);
        col = int.Parse(input[1]);
        size = int.Parse(input[2]);
        isCabbage = new bool[row, col];
        isCheck = new bool[row, col];

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            posX = int.Parse(input[0]);
            posY = int.Parse(input[1]);
            isCabbage[posX, posY] = true;
        }

        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (!isCheck[i, j] && isCabbage[i, j])
                {
                    BFS(isCheck, isCabbage, i, j);
                    count++;
                }
            }
        }

        return count;
    }

    static void BFS(bool[,] isCheck, bool[,] isCabbage, int posX, int posY)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        (int, int)[] direction = { (-1, 0), (1, 0), (0, -1), (0, 1) };
        int row = isCheck.GetLength(0);
        int col = isCheck.GetLength(1);
        int curX;
        int curY;

        queue.Enqueue((posX, posY));
        isCheck[posX, posY] = true;

        while (queue.Count > 0)
        {
            var pos = queue.Dequeue();
            foreach (var dir in direction)
            {
                curX = pos.Item1 + dir.Item1;
                curY = pos.Item2 + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < row && curY < col
                    && !isCheck[curX, curY] && isCabbage[curX, curY])
                {
                    queue.Enqueue((curX, curY));
                    isCheck[curX, curY] = true;
                }
            }
        }
    }

    static void PrintResult(int value)
    {
        SW.WriteLine(value);
    }
}