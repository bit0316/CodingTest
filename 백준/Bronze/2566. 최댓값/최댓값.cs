public class Program
{
    static void Main(string[] args)
    {
        int row = 9;
        int col = 9;
        int[,] matrix;
        string[] input;

        matrix = SetMatrix(row, col);
        FindMaxValue(matrix);
    }

    static int[,] SetMatrix(int row, int col)
    {
        int[,] matrix = new int[row, col];
        string[] input;

        for (int i = 0; i < row; ++i)
        {
            input = Console.ReadLine().Split();
            for (int j = 0; j < col; ++j)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }

        return matrix;
    }

    static void FindMaxValue(int[,] matrix)
    {
        int max = 0;
        int indexRow = 1;
        int indexCol = 1;
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    indexRow = i + 1;
                    indexCol = j + 1;
                }
            }
        }

        Console.WriteLine(max);
        Console.WriteLine($"{indexRow} {indexCol}");
    }
}