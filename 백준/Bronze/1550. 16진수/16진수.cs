public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        SW.WriteLine(Convert.ToInt32(SR.ReadLine(), 16));

        SR.Close();
        SW.Close();
    }
}