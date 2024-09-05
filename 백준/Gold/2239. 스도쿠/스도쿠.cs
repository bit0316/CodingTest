public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size = 9;

    static List<(int, int)> blanks = new List<(int, int)>();
    static int[,] arr = new int[size, size];
    static bool isAnswer = false;

    static void Main(string[] args)
    {
        SetArray();
        Sudoku(0);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        string input;

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine();
            for (int j = 0; j < size; ++j)
            {
                arr[i, j] = int.Parse(input[j].ToString());
                if (arr[i, j] == 0)
                {
                    blanks.Add((i, j));
                }
            }
        }
    }

    static void Sudoku(int depth)
    {
        int posX;
        int posY;

        if (depth == blanks.Count)
        {
            isAnswer = true;
            return;
        }

        (posX, posY) = blanks[depth];
        for (int i = 1; i <= size; ++i)
        {
            if (IsValid(posX, posY, i))
            {
                arr[posX, posY] = i;
                Sudoku(depth + 1);
            }

            if (isAnswer)
            {
                break;
            }
            arr[posX, posY] = 0;
        }
    }

    static bool IsValid(int row, int col, int num)
    {
        int posX = row / 3 * 3;
        int posY = col / 3 * 3;

        for (int i = 0; i < 9; ++i)
        {
            if (arr[row, i] == num || arr[i, col] == num)
            {
                return false;
            }
        }

        for (int i = posX; i < posX + 3; ++i)
        {
            for (int j = posY; j < posY + 3; ++j)
            {
                if (arr[i, j] == num)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void PrintResult()
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                SW.Write(arr[i, j]);
            }
            SW.WriteLine();
        }
    }
}