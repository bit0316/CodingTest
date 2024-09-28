public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static char[][] tower;
    static int size;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());

        SetTower();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetTower()
    {
        tower = new char[size][];
        for (int i = 0; i < size; ++i)
        {
            tower[i] = SR.ReadLine().ToCharArray();
        }
    }

    static int GetResult()
    {
        int result = IsValid() ? 1 : 0;

        return result;
    }

    static bool IsValid()
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j <= i; ++j)
            {
                if (tower[i][j] == 'R' && IsValidRed(i, j))
                {
                    tower[i][j] = ' ';
                    tower[i + 1][j] = ' ';
                    tower[i + 1][j + 1] = ' ';
                }
                else if (tower[i][j] == 'B' && IsValidBlue(i, j))
                {
                    tower[i][j] = ' ';
                    tower[i][j + 1] = ' ';
                    tower[i + 1][j + 1] = ' ';
                }
                else if (tower[i][j] != ' ')
                {
                    return false;
                }
            }
        }
        return true;
    }

    static bool IsValidRed(int row, int col)
    {
        return row + 1 < size && tower[row + 1][col] == 'R' && tower[row + 1][col + 1] == 'R';
    }

    static bool IsValidBlue(int row, int col)
    {
        return row + 1 < size && col + 1 <= row && tower[row][col + 1] == 'B' && tower[row + 1][col + 1] == 'B';
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}