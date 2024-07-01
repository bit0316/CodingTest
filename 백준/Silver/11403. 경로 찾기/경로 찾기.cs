public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[][] map;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        SetMap();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        int[] input;

        map = new int[size][];
        for (int i = 0; i < size; ++i)
        {
            map[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        }

    }

    static void GetResult()
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                for (int k = 0; k < size; ++k)
                {
                    if (map[j][i] == 1 && map[i][k] == 1)
                    {
                        map[j][k] = 1;
                    }
                }
            }
        }
    }

    static void PrintResult()
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                SW.Write($"{map[i][j]} ");
            }
            SW.WriteLine();
        }
    }
}