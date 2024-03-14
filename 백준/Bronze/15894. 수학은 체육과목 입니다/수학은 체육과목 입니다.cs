public class Program
{
    static void Main(string[] args)
    {
        long num;
        long result;

        num = long.Parse(Console.ReadLine());

        result = GetArea(num);
        Console.WriteLine(result);
    }

    static long GetArea(long num)
    {
        return num * 4;
    }       
}