public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num = int.Parse(SR.ReadLine());

        for (int i = 0; i < num; ++i)
        {
            for (int j = 0; j < i; ++j)
            {
                SW.Write(" ");
            }
            for (int j = 2 * (num - i) - 1; j > 0; --j)
            {
                SW.Write("*");
            }
            SW.WriteLine();
        }

        for (int i = num - 2; i >= 0; --i)
        {
            for (int j = 0; j < i; ++j)
            {
                SW.Write(" ");
            }
            for (int j = 2 * (num - i) - 1; j > 0; --j)
            {
                SW.Write("*");
            }
            SW.WriteLine();
        }

        SR.Close();
        SW.Close();
    }
}