public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int[] fractionA = new int[2];
        int[] fractionB = new int[2];
        long[] result;

        SetFraction(fractionA);
        SetFraction(fractionB);

        result = GetIrreducibleFraction(fractionA, fractionB);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetFraction(int[] fraction)
    {
        string[] input = SR.ReadLine().Split();

        fraction[0] = int.Parse(input[0]);
        fraction[1] = int.Parse(input[1]);
    }

    static long[] GetIrreducibleFraction(int[] fractionA, int[] fractionB)
    {
        long[] fraction = new long[2];
        long lcm;
        long gcd;

        lcm = GetLCM(fractionA[1], fractionB[1]);
        fraction[0] = fractionA[0] * lcm / fractionA[1] + fractionB[0] * lcm / fractionB[1];
        fraction[1] = lcm;

        gcd = GetGCD(fraction[0], fraction[1]);
        fraction[0] /= gcd;
        fraction[1] /= gcd;

        return fraction;
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

    static void PrintResult(long[] arr)
    {
        SW.WriteLine($"{arr[0]} {arr[1]}");
        
        SW.Flush();
    }
}