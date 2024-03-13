public class Program
{
    static void Main(string[] args)
    {
        int size;

        size = int.Parse(Console.ReadLine());

        Console.WriteLine(GetCount(size));
    }

    static int GetCount(int size)
    {
        int count = 1;

        while(size > 1)
        {
            size -= count * 6;
            count++;
        }

        return count;
    }
}