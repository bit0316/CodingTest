public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<string, string> seminars = new Dictionary<string, string>()
    {
        { "Algorithm", "204" },
        { "DataAnalysis", "207" },
        { "ArtificialIntelligence", "302" },
        { "CyberSecurity", "B101" },
        { "Network", "303" },
        { "Startup", "501" },
        { "TestStrategy", "105" },
    };

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            SW.WriteLine(seminars[SR.ReadLine()]);
        }

        SR.Close();
        SW.Close();
    }
}