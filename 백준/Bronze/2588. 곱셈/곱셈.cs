public class Program
{
    static void Main(string[] args)
    {
        int numA;
        int numB;

        numA = Convert.ToInt32(Console.ReadLine());
        numB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(numA * (numB % 10));
        Console.WriteLine(numA * (numB / 10 % 10));
        Console.WriteLine(numA * (numB / 100));
        Console.WriteLine(numA * numB);
    }
}