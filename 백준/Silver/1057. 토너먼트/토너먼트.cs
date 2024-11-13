public class Program
{
    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int numA = input[1];
        int numB = input[2];
        int count = 0;

        while (numA != numB)
        {
            numA = (numA + 1) / 2;
            numB = (numB + 1) / 2;
            count++;
        }

        Console.WriteLine(count);
    }
}