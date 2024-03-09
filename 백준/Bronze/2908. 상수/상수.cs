public class Program
{
    static void Main(string[] args)
    {
        int numA;
        int numB;
        int reverseA = 0;
        int reverseB = 0;
        int size = 3;
        string[] input;

        input = Console.ReadLine().Split();
        numA = int.Parse(input[0]);
        numB = int.Parse(input[1]);

        for (int i = 0;  i < size; ++i)
        {
            reverseA *= 10;
            reverseB *= 10;
            reverseA += numA % 10;
            reverseB += numB % 10;
            numA /= 10;
            numB /= 10;
        }

        if (reverseA > reverseB)
        {
            Console.WriteLine(reverseA);
        }
        else
        {
            Console.WriteLine(reverseB);
        }
    }
}