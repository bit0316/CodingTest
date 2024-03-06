public class Program
{
    static void Main(string[] args)
    {
        int numA;
        int numB;
        int sum;
        string input;
        string[] split;

        while (true)
        {
            input = Console.ReadLine();
            if (input == null)
            {
                break;
            }

            split = input.Split();
            numA = int.Parse(split[0]);
            numB = int.Parse(split[1]);
            sum = numA + numB;

            Console.WriteLine(sum);
        }
    }
}