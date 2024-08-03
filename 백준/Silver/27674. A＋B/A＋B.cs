public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        long numA;
        long numB;
        char[] input;
        string text;

        size = int.Parse(SR.ReadLine());
        SR.ReadLine();

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().OrderByDescending(x => x).ToArray();
            text = new string(input);
            SR.ReadLine();

            numA = long.Parse(text.Substring(0, input.Length - 1));
            numB = long.Parse(text[input.Length - 1].ToString());

            SW.WriteLine(numA + numB);
        }

        SR.Close();
        SW.Close();
    }
}