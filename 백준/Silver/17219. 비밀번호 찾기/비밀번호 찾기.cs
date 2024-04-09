public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<string, string> passwords = new Dictionary<string, string>();
    static int setSize;
    static int searchSize;
    static string[] input;

    static void Main(string[] args)
    {
        input = SR.ReadLine().Split();
        setSize = int.Parse(input[0]);
        searchSize = int.Parse(input[1]);

        SetPasswords();
        SearchPassword();

        SR.Close();
        SW.Close();
    }

    static void SetPasswords()
    {
        for (int i = 0; i < setSize; i++)
        {
            input = SR.ReadLine().Split();
            passwords.Add(input[0], input[1]);
        }
    }

    static void SearchPassword()
    {
        for (int i = 0; i < searchSize; i++)
        {
            input[0] = SR.ReadLine();
            passwords.TryGetValue(input[0], out string value);
            PrintResult(value);
        }
    }

    static void PrintResult(string result)
    {
        SW.WriteLine(result);
    }
}