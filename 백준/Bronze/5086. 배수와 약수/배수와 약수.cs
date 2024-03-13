public class Program
{
    static void Main(string[] args)
    {
        int numA;
        int numB;
        string[] input;

        while (true)
        {
            input = Console.ReadLine().Split();
            numA = int.Parse(input[0]);
            numB = int.Parse(input[1]);

            if (numA == 0 && numB == 0)
            {
                break;
            }

            PrintResult(numA, numB);
        }

    }

    static void PrintResult(int numA, int numB)
    {
        if (numA % numB == 0)
        {
            Console.WriteLine("multiple");
        }
        else if (numB % numA == 0)
        {
            Console.WriteLine("factor");
        }
        else
        {
            Console.WriteLine("neither");
        }
    }
}