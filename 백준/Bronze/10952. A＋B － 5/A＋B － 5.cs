public class Program
{
    static void Main(string[] args)
    {
        int numA;
        int numB;
        int sum;
        string[] input;

        while (true)
        {
            input = Console.ReadLine().Split();
            numA = int.Parse(input[0]);
            numB = int.Parse(input[1]);
            sum = numA + numB;

            if (sum == 0)
            {
                break;
            }
            Console.WriteLine(sum);
        }
    }
}