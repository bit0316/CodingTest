public class Program
{
    static void Main(string[] args)
    {
        int A;
        int B;
        string[] input;

        input = Console.ReadLine().Split();
        A = Convert.ToInt32(input[0]);
        B = Convert.ToInt32(input[1]);

        Console.WriteLine((double)A / B);
    }
}