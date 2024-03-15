public class Program
{
    static void Main(string[] args)
    {
        int row;
        int col;
        int[,] board;
        string[] input;

        input = Console.ReadLine().Split();
        row = int.Parse(input[0]);
        col = int.Parse(input[1]);
        
        board = SetBoard(row, col);

        Console.WriteLine(GetMinCount(board, row, col));
    }

    static int[,] SetBoard(int row, int col)
    {
        int[,] board;
        string input;

        board = new int[row, col];
        for (int i = 0; i < row; ++i)
        {
            input = Console.ReadLine();
            for (int j = 0; j < col; ++j)
            {
                board[i, j] = input[j] == 'B' ? 0 : 1;
            }
        }

        return board;
    }

    static int GetMinCount(int[,] board, int row, int col)
    {
        int size = 8;
        int min = row * col;
        int count;

        for (int i = 0; i <= row - size; ++i)
        {
            for (int j = 0; j <= col - size; ++j)
            {
                count = GetPaintCount(board, i, j, 0);
                if (min > count)
                {
                    min = count;
                }

                count = GetPaintCount(board, i, j, 1);
                if (min > count)
                {
                    min = count;
                }
            }
        }

        return min;
    }

    static int GetPaintCount(int[,] board, int posX, int posY, int color)
    {
        int bw;
        int count = 0;

        for (int i = posX; i < posX + 8; ++i)
        {
            for (int j = posY; j < posY + 8; ++j)
            {
                bw = (i + j + color) % 2;
                if (board[i, j] == bw || board[i, j] == bw)
                {
                    count++;
                }
            }
        }

        return count;
    }
}