public class Program
{
    static void Main(string[] args)
    {
        int numA;
        int numB;
        string[] input;

        input = Console.ReadLine().Split();
        numA = int.Parse(input[0]);
        numB = int.Parse(input[1]);

        if (numA > numB)
        {
            Console.WriteLine(">");
        }
        else if (numA < numB)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("==");
        }
    }
}