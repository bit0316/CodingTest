public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int numA;
        int numB;
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        numA = input[0];
        numB = input[1];

        result = (numA + numB) * (numA - numB);
        SW.WriteLine(result);

        SR.Close();
        SW.Close();
    }
}