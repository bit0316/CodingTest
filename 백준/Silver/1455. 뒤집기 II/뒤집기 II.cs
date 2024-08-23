public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int[,] coin;
    static int row;
    static int col;

    static void Main(string[] args)
    {
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];

        SetMap();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        string input;

        coin = new int[row, col];
        for (int i = 0; i < row; ++i)
        {
            input = SR.ReadLine();
            for (int j = 0; j < col; ++j)
            {
                coin[i, j] = int.Parse(input[j].ToString());
            }
        }
    }

    static int GetResult()
    {
        int count = 0;

        for (int i = row - 1; i >= 0; --i)
        {
            for (int j = col - 1; j >= 0; --j)
            {
                if (coin[i, j] == 1)
                {
                    count++;
                    ReverseCoin(i, j);
                }
            }
        }

        return count;
    }

    static void ReverseCoin(int posX, int posY)
    {
        for (int i = 0; i <= posX; ++i)
        {
            for (int j = 0; j <= posY; ++j)
            {
                coin[i, j] = coin[i, j] == 1 ? 0 : 1;
            }
        }
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}