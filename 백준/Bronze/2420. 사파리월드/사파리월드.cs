public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        long numA;
        long numB;
        long result;
        long[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), long.Parse);
        numA = input[0];
        numB = input[1];

        result = Math.Abs(numA - numB);
        SW.WriteLine(result);

        SR.Close();
        SW.Close();
    }
}