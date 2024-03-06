public class Program
{
    static void Main(string[] args)
    {
        int X;
        int N;
        int a;
        int b;
        int total = 0;
        string[] input;

        X = int.Parse(Console.ReadLine());
        N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; ++i)
        {
            input = Console.ReadLine().Split();
            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
            total += a * b;
        }

        if (total == X)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}