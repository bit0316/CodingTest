public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            SW.WriteLine(SR.ReadLine().ToLower());
        }

        SR.Close();
        SW.Close();
    }
}