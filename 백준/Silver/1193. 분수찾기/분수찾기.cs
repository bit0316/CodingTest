public class Program
{
    static void Main(string[] args)
    {
        int size;

        size = int.Parse(Console.ReadLine());

        PrintResult(size);
    }

    static void PrintResult(int size)
    {
        int index = 1;
        int numA;
        int numB;

        while (size > index)
        {
            size -= index;
            index++;
        }

        if (index % 2 == 0)
        {
            numA = size;
            numB = index - size + 1;
        }
        else
        {
            numA = index - size + 1;
            numB = size;
        }

        Console.WriteLine($"{numA}/{numB}");
    }
}