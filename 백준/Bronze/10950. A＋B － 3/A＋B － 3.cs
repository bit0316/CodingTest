public class Program
{
    static void Main(string[] args)
    {
        int count;
        int numA;
        int numB;
        string[] input;

        count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; ++i)
        {
            input = Console.ReadLine().Split();
            numA = int.Parse(input[0]);
            numB = int.Parse(input[1]);

            Console.WriteLine(numA + numB);
        }
    }
}