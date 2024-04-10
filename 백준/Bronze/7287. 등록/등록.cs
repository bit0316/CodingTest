public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        SW.WriteLine(200);
        SW.WriteLine("bit0316");

        SR.Close();
        SW.Close();
    }
}