public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            GetResult();
        }

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int row = input[0];
        int col = input[1];

        SW.WriteLine(1);
        SW.WriteLine("(0,0)");
        for (int i = 0; i < row; ++i)
        {
            if (i % 2 == 0)
            {
                for (int j = 1; j < col; ++j)
                {
                    SW.WriteLine($"({i},{j})");
                }
            }
            else
            {
                for (int j = col - 1; j > 0; --j)
                {
                    SW.WriteLine($"({i},{j})");
                }
            }
        }

        for (int i = row - 1; i > 0; --i)
        {
            SW.WriteLine($"({i},0)");
        }
    }
}