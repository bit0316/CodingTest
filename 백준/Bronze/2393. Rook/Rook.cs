public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        SW.WriteLine("  ___  ___  ___");
        SW.WriteLine("  | |__| |__| |");
        SW.WriteLine("  |           |");
        SW.WriteLine("   \\_________/");
        SW.WriteLine("    \\_______/");
        SW.WriteLine("     |     |");
        SW.WriteLine("     |     |");
        SW.WriteLine("     |     |");
        SW.WriteLine("     |     |");
        SW.WriteLine("     |_____|");
        SW.WriteLine("  __/       \\__");
        SW.WriteLine(" /             \\");
        SW.WriteLine("/_______________\\");

        SR.Close();
        SW.Close();
    }
}