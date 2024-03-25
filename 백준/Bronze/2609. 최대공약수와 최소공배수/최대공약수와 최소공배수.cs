public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int numA;
        int numB;
        int lcm;
        int gcd;
        string[] input;

        input = SR.ReadLine().Split();
        numA = int.Parse(input[0]);
        numB = int.Parse(input[1]);
        (numA, numB) = numA > numB ? (numA, numB) : (numB, numA);

        gcd = GetGCD(numA, numB);
        lcm = GetLCM(numA, numB, gcd);
        PrintResult(gcd, lcm);

        SR.Close();
        SW.Close();
    }

    static int GetLCM(int numA, int numB, int gcd)
    {
        return (numA * numB) / gcd;
    }

    static int GetGCD(int numA, int numB)
    {
        int remain = numA % numB;

        return remain != 0 ? GetGCD(numB, remain) : numB;
    }

    static void PrintResult(int gcd, int lcm)
    {
        SW.WriteLine(gcd);
        SW.WriteLine(lcm);

        SW.Flush();
    }
}