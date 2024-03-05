public class Program
{
    static void Main(string[] args)
    {
        string[] input;
        int A;
        int B;
        int C;

        input = Console.ReadLine().Split();
        A = Convert.ToInt32(input[0]);
        B = Convert.ToInt32(input[1]);
        C = Convert.ToInt32(input[2]);

        Console.WriteLine((A + B) % C);
        Console.WriteLine(((A % C) + (B % C)) % C);
        Console.WriteLine((A * B) % C);
        Console.WriteLine(((A % C) * (B % C)) % C);
    }
}