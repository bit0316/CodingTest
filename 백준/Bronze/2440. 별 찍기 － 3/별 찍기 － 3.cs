public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;

        size = int.Parse(SR.ReadLine());
        PrintStar(size);

        SR.Close();
        SW.Close();
    }

    static void PrintStar(int size)
    {
        for (int row = size; row > 0; --row)
        {
            for (int col = row; col > 0; --col)
            {
                SW.Write("*");
            }
            SW.WriteLine();
        }
    }
}