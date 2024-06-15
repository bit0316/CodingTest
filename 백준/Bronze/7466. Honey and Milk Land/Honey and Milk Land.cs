public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int width;
    static int height;
    static int row;
    static int col;
    static string[] input;

    static void Main(string[] args)
    {
        input = SR.ReadLine().Split();
        col = int.Parse(input[0]);
        row = int.Parse(input[1]);

        if (col > 1)
        {
            input = SR.ReadLine().Split();
            for (int i = 0; i < col - 1; ++i)
            {
                height += int.Parse(input[i]);
            }
        }
        else
        {
            SR.ReadLine();
        }

        if (row > 1)
        {
            input = SR.ReadLine().Split();
            for (int i = 0; i < row - 1; ++i)
            {
                width += int.Parse(input[i]);
            }
        }
        else
        {
            SR.ReadLine();
        }

        SW.WriteLine(Math.Ceiling(Math.Sqrt(width * width + height * height)));

        SR.Close();
        SW.Close();
    }
}