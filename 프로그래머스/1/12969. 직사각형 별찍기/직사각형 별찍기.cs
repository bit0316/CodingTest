using System;

public class Example
{
    public static void Main()
    {
        int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int col = num[0];
        int row = num[1];

        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}