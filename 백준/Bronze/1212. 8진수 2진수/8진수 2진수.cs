public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int octal;
        string input;

        input = SR.ReadLine();

        octal = int.Parse(input[0].ToString());
        SW.Write(Convert.ToString(octal, 2));
        for (int i = 1; i < input.Length; ++i)
        {
            octal = int.Parse(input[i].ToString());
            SW.Write(Convert.ToString(octal, 2).PadLeft(3, '0'));
        }

        SR.Close();
        SW.Close();
    }
}