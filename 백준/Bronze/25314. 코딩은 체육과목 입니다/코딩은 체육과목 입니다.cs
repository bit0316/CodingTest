public class Program
{
    static void Main(string[] args)
    {
        int N;

        N = int.Parse(Console.ReadLine());

        while (N > 0)
        {
            Console.Write("long ");
            N -= 4;
        }
        Console.WriteLine("int");
    }
}