public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string input;

        input = SR.ReadLine();

        for (int i = 0; i < input.Length; ++i)
        {
            SW.Write(char.IsUpper(input[i]) ? char.ToLower(input[i]) : char.ToUpper(input[i]));
        }

        SR.Close();
        SW.Close();
    }
}