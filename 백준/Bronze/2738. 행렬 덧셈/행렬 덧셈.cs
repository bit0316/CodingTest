public class Program
{
    static void Main(string[] args)
    {
        int row;
        int col;
        int[,] matrixA;
        int[,] matrixB;
        int[,] matrixC;
        string[] input;

        input = Console.ReadLine().Split();
        row = int.Parse(input[0]);
        col = int.Parse(input[1]);

        matrixA = SetMatrix(row, col);
        matrixB = SetMatrix(row, col);
        matrixC = SumMatrix(matrixA, matrixB);

        PrintMatrix(matrixC);
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

    static int[,] SumMatrix(int[,] matrixA, int[,] matrixB)
    {
        int row = matrixA.GetLength(0);
        int col = matrixA.GetLength(1);
        int[,] matrixC = new int[row, col];

        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return matrixC;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}