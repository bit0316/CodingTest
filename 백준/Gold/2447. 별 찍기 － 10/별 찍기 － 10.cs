public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        char[,] arr;

        size = int.Parse(SR.ReadLine());
        arr = new char[size, size];

        InitArray(arr);
        SetArray(arr, size, 0, 0);
        DrawArray(arr);

        SR.Close();
        SW.Close();
    }

    static void InitArray(char[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); ++i)
        {
            for (int j = 0; j < arr.GetLength(1); ++j)
            {
                arr[i, j] = ' ';
            }
        }
    }

    static void SetArray(char[,] arr, int size, int row, int col)
    {
        int div = size / 3;

        if (size == 1)
        {
            arr[row, col] = '*';
            return;
        }

        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                if (i == 1 && j == 1)
                {
                    continue;
                }

                SetArray(arr, div, row + div * i, col + div * j);
            }
        }
    }

    static void DrawArray(char[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); ++i)
        {
            for (int j = 0; j < arr.GetLength(1); ++j)
            {
                SW.Write(arr[i, j]);
            }
            SW.WriteLine();
        }
    }
}