public class Program
{
    static void Main(string[] args)
    {
        string[] input;
        long numA;
        long numB;
        long numC;

        input = Console.ReadLine().Split();
        numA = long.Parse(input[0]);
        numB = long.Parse(input[1]);
        numC = long.Parse(input[2]);

        Console.WriteLine(numA + numB + numC);
    }
}