public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static bool[,] isBlue;
    static int blue = 0;
    static int white = 0;
    static int[] input;

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());
        isBlue = new bool[size, size];

        SetArray(size);
        CheckColor(size, 0, 0);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetArray(int size)
    {
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 0; j < size; ++j)
            {
                isBlue[i, j] = input[j] == 1 ? true : false;
            }
        }
    }

    static void CheckColor(int size, int row, int col)
    {
        int half = size / 2;
        for (int i = row; i < row + size; ++i)
        {
            for (int j = col; j < col + size; ++j)
            {
                if (isBlue[i, j] != isBlue[row, col])
                {
                    CheckColor(half, row, col);
                    CheckColor(half, row + half, col);
                    CheckColor(half, row, col + half);
                    CheckColor(half, row + half, col + half);

                    return;
                }
            }
        }

        if (isBlue[row, col])
        {
            blue++;
        }
        else
        {
            white++;
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(white);
        SW.WriteLine(blue);
    }
}