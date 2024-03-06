using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int T;
        int A;
        int B;
        string[] input;

        T = int.Parse(Console.ReadLine());

        for (int i = 1; i <= T; ++i)
        {
            input = Console.ReadLine().Split();
            A = int.Parse(input[0]);
            B = int.Parse(input[1]);

            Console.WriteLine($"Case #{i}: {A + B}");
        }
    }
}