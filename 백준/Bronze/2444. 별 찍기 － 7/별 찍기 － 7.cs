public class Program
{
    static void Main(string[] args)
    {
        int size;

        size = int.Parse(Console.ReadLine());

        for (int row = 1; row <= size; ++row)
        {
            for (int col = 1; col < size + row; ++col)
            {
                if (col <= size - row)
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

        for (int row = size - 1; row > 0; --row)
        {
            for (int col = 1; col < size + row; ++col)
            {
                if (col <= size - row)
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