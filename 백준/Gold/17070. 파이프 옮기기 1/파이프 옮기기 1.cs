public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int result;
    static int[,] map;

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
        int[] input;

        map = new int[size + 1, size + 1];
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 0; j < size; ++j)
            {
                map[i, j] = input[j];
            }
        }
    }

    static void GetResult()
    {
        result = 0;

        DFS(0, 1, 0);
    }

    static void DFS(int posX, int posY, int dir)
    {
        if (posX == size || posY == size)
        {
            return;
        }

        if (posX == size - 1 && posY == size - 1)
        {
            result++;
            return;
        }

        if ((dir == 0 || dir == 2) && map[posX, posY + 1] == 0)
        {
            DFS(posX, posY + 1, 0);
        }
        if ((dir == 1 || dir == 2) && map[posX + 1, posY] == 0)
        {
            DFS(posX + 1, posY, 1);
        }
        if (map[posX, posY + 1] == 0 && map[posX + 1, posY] == 0 && map[posX + 1, posY + 1] == 0)
        {
            DFS(posX + 1, posY + 1, 2);
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}