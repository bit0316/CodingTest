public class Program
{
    static void Main(string[] args)
    {
        int num;

        num = int.Parse(Console.ReadLine());

        for (int row = 1; row <= num; ++row)
        {
            for (int col = 1; col <= num; ++col)
            {
                if (num - row >= col)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}