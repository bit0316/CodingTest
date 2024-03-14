public class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        int c;
        int n;
        int result;
        string[] input;

        input = Console.ReadLine().Split();
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        c = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());

        result = (a * n + b <= c * n) && (a <= c) ? 1 : 0;
        Console.WriteLine(result);
    }
}