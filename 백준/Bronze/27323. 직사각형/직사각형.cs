public class Program
{
    static void Main(string[] args)
    {
        int numA;
        int numB;
        int area;

        numA = int.Parse(Console.ReadLine());
        numB = int.Parse(Console.ReadLine());

        area = GetArea(numA, numB);
        Console.WriteLine(area);
    }

    static int GetArea(int numA, int numB)
    {
        return numA * numB;
    }
}