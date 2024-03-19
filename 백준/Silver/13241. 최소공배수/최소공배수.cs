public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int numA;
        int numB;
        long result;
        string[] input;

        input = SR.ReadLine().Split();
        numA = int.Parse(input[0]);
        numB = int.Parse(input[1]);

        result = GetLCM(numA, numB);
        SW.WriteLine(result);

        SR.Close();
        SW.Close();
    }

    static long GetLCM(long numA, long numB)
    {
        (numA, numB) = numA > numB ? (numA, numB) : (numB, numA);

        return (numA * numB) / GetGCD(numA, numB);
    }

    static long GetGCD(long numA, long numB)
    {
        long remain = numA % numB;

        return remain != 0 ? GetGCD(numB, remain) : numB;
    }
}