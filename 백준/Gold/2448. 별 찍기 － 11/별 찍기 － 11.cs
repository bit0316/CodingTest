public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static char[,] arr;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = new char[size, size * 2];

        InitStar();
        SetStar(size, 0, size - 1);
        DrawStar();

        SR.Close();
        SW.Close();
    }

    static void InitStar()
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size * 2; ++j)
            {
                arr[i, j] = ' ';
            }
        }
    }

    static void SetStar(int len, int row, int col)
    {
        if (len == 3)
        {
            arr[row, col] = '*';
            arr[row + 1, col - 1] = '*';
            arr[row + 1, col + 1] = '*';
            arr[row + 2, col - 2] = '*';
            arr[row + 2, col - 1] = '*';
            arr[row + 2, col] = '*';
            arr[row + 2, col + 1] = '*';
            arr[row + 2, col + 2] = '*';
            return;
        }

        SetStar(len / 2, row, col);
        SetStar(len / 2, row + len / 2, col - len / 2);
        SetStar(len / 2, row + len / 2, col + len / 2);
    }

    static void DrawStar()
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size * 2; ++j)
            {
                SW.Write(arr[i, j]);
            }
            SW.WriteLine();
        }
    }
}