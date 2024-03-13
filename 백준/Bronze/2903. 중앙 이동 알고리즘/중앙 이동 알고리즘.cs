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
        int length = 2;
        int result = 0;

        for (int i = 0; i < size; ++i)
        {
            length += length - 1;
            result = length * length;
        }

        return result;
    }
}