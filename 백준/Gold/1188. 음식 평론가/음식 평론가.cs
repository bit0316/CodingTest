public class Program
{
    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine(input[1] - GetGCD(input[0], input[1]));
    }

    static int GetGCD(int numA, int numB)
    {
        while(numB > 0)
        {
            (numA, numB) = (numB, numA % numB);
        }

        return numA;
    }
}