public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAP_SIZE = 4;

    static char[][] map;

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());

        for (int i = 1; i <= size; ++i)
        {
            SetMap();
            if (IsWinner('O'))
            {
                PrintResult(i, "O won");
            }
            else if (IsWinner('X'))
            {
                PrintResult(i, "X won");
            }
            else if (IsCompleted())
            {
                PrintResult(i, "Draw");
            }
            else
            {
                PrintResult(i, "Game has not completed");
            }
        }

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new char[MAP_SIZE][];
        for (int i = 0; i < MAP_SIZE; ++i)
        {
            map[i] = SR.ReadLine().ToCharArray();
        }
        SR.ReadLine();
    }

    static bool IsWinner(char marker)
    {
        if (CheckRow(marker) || CheckColumn(marker) ||
            CheckLTRB(marker) || CheckLBRT(marker))
        {
            return true;
        }
        return false;
    }

    static bool CheckRow(char marker)
    {
        bool isWinner = true;

        for (int i = 0; i < MAP_SIZE; ++i)
        {
            isWinner = true;
            for (int j = 0; j < MAP_SIZE; ++j)
            {
                if (map[i][j] != marker && map[i][j] != 'T')
                {
                    isWinner = false;
                    break;
                }
            }
            if (isWinner)
            {
                return isWinner;
            }
        }
        return isWinner;
    }

    static bool CheckColumn(char marker)
    {
        bool isWinner = true;

        for (int i = 0; i < MAP_SIZE; ++i)
        {
            isWinner = true;
            for (int j = 0; j < MAP_SIZE; ++j)
            {
                if (map[j][i] != marker && map[j][i] != 'T')
                {
                    isWinner = false;
                    break;
                }
            }
            if (isWinner)
            {
                return isWinner;
            }
        }
        return isWinner;
    }

    static bool IsCompleted()
    {
        for (int i = 0; i < MAP_SIZE; ++i)
        {
            for (int j = 0; j < MAP_SIZE; ++j)
            {
                if (map[i][j] == '.')
                {
                    return false;
                }
            }
        }
        return true;
    }

    static bool CheckLTRB(char marker)
    {
        for (int i = 0; i < MAP_SIZE; ++i)
        {
            if (map[i][i] != marker && map[i][i] != 'T')
            {
                return false;
            }
        }
        return true;
    }

    static bool CheckLBRT(char marker)
    {
        for (int i = 0; i < MAP_SIZE; ++i)
        {
            if (map[i][MAP_SIZE - i - 1] != marker && map[i][MAP_SIZE - i - 1] != 'T')
            {
                return false;
            }
        }
        return true;
    }

    static void PrintResult(int index, string str)
    {
        SW.WriteLine($"Case #{index}: {str}");
    }
}