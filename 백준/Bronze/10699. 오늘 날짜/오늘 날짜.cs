public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        SW.WriteLine(DateTime.Today.ToString("yyyy-MM-dd"));

        SR.Close();
        SW.Close();
    }
}