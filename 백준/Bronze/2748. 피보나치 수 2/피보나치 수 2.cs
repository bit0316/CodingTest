public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        long before = 0;
        long current = 1;

        for (int i = 1; i < size; ++i)
        {
            (before, current) = (current, before + current);
        }
        SW.WriteLine(current);

        SR.Close();
        SW.Close();
    }
}