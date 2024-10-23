public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<char, string> dict = new Dictionary<char, string>
    {
        { 'B', "v" }, { 'E', "ye" },  { 'H', "n" }, { 'P', "r" }, { 'C', "s" }, { 'Y', "u" }, { 'X', "h" }
    };

    static void Main(string[] args)
    {
        string input = SR.ReadLine();

        foreach (char ch in input)
        {
            SW.Write(dict.ContainsKey(ch) ? dict[ch] : char.ToLower(ch));
        }

        SR.Close();
        SW.Close();
    }
}