public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string input;

        while (true)
        {
            input = SR.ReadLine();
            if (input == "END")
            {
                break;
            }
            SW.WriteLine(new string(input.Reverse().ToArray()));
        }

        SR.Close();
        SW.Close();
    }
}