public class Program
{
    static void Main(string[] args)
    {
        int[] cent = { 25, 10, 5, 1 };
        int size;
        
        size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            PrintChange(cent);
        }
    }

    static void PrintChange(int[] cent)
    {
        int money;
        int count;

        money = int.Parse(Console.ReadLine());

        for (int i = 0; i < cent.Length; ++i)
        {
            count = money / cent[i];
            Console.Write($"{count} ");
            money -= cent[i] * count;
        }
        Console.WriteLine();
    }
}