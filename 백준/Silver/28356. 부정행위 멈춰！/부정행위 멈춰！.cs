public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int[,] test = { { 1, 2 }, { 3, 4 } };
    static int row;
    static int col;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];

        if (row == 1 && col == 1)
        {
            SW.WriteLine(1);
            SW.WriteLine(1);
        }
        else if (row > 1 && col > 1)
        {
            SW.WriteLine(4);
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    SW.Write($"{test[i % 2, j % 2]} ");
                }
                SW.WriteLine();
            }
        }
        else
        {
            SW.WriteLine(2);
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    SW.Write($"{test[0, (i + j) % 2]} ");
                }
                SW.WriteLine();
            }
        }

        SR.Close();
        SW.Close();
    }
}