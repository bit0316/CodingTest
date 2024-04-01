public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        string input;

        while (true)
        {
            input = SR.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            size = int.Parse(input);
            PrintCantor(size);
            SW.WriteLine();
            SW.Flush();
        }

        SR.Close();
        SW.Close();
    }

    static void PrintCantor(int size)
    {
        int count = (int)Math.Pow(3, size - 1);

        if (size == 0)
        {
            SW.Write("-");
            return;
        }

        PrintCantor(size - 1);
        for (int i = 0; i < count; ++i)
        {
            SW.Write(" ");
        }
        PrintCantor(size - 1);
    }
}