public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int row;
    static int col;
    static int perimeter;
    static long count;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];
        perimeter = input[2];

        for (int i = 1; i <= row; ++i)
        {
            for (int j = 1; j <= col; ++j)
            {
                if (i * 2 + j * 2 >= perimeter)
                {
                    count += (row - i + 1) * (col - j + 1);
                }
            }
        }
        SW.WriteLine(count);

        SR.Close();
        SW.Close();
    }
}