public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int row;
    static int col;
    static char[][] map;

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

        map = new char[row][];
        for (int i = 0; i < row; ++i)
        {
            map[i] = SR.ReadLine().ToCharArray();
        }
    }

    static int GetResult()
    {
        int countRow = row;
        int countCol = col;

        for (int i = 0; i < row; ++i)
        {
            if (map[i].Contains('X'))
            {
                countRow--;
            }
        }

        for (int i = 0; i < col; ++i)
        {
            for (int j = 0; j < row; ++j)
            {
                if (map[j][i] == 'X')
                {
                    countCol--;
                    break;
                }
            }
        }

        return Math.Max(countRow, countCol);
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}