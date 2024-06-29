public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static string[] pledges =
    {
        "Never gonna give you up",
        "Never gonna let you down",
        "Never gonna run around and desert you",
        "Never gonna make you cry",
        "Never gonna say goodbye",
        "Never gonna tell a lie and hurt you",
        "Never gonna stop"
    };

    static void Main(string[] args)
    {
        bool isChanged = false;

        for (int i = int.Parse(SR.ReadLine()); i > 0; --i)
        {
            if (!pledges.Contains(SR.ReadLine()))
            {
                isChanged = true;
            }
        }

        if (!isChanged)
        {
            SW.WriteLine("No");
        }
        else
        {
            SW.WriteLine("Yes");
        }

        SR.Close();
        SW.Close();
    }
}