public class Program
{
    static void Main(string[] args)
    {
        int a, b, c, d, e, f;
        int x, y;
        string[] input;

        input = Console.ReadLine().Split();
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        c = int.Parse(input[2]);
        d = int.Parse(input[3]);
        e = int.Parse(input[4]);
        f = int.Parse(input[5]);

        PrintResult(a, b, c, d, e, f);
    }

    static void PrintResult(int a, int b, int c, int d, int e, int f)
    {
        int x, y;

        if (a * e != b * d)
        {
            x = (c * e - b * f) / (a * e - b * d);
            y = (a * f - c * d) / (a * e - b * d);

            Console.WriteLine($"{x} {y}");
        }
    }
}