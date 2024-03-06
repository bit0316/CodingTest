using System;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int T;
        int A;
        int B;
        string[] input;
        StringBuilder sb = new StringBuilder();

        T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; ++i)
        {
            input = Console.ReadLine().Split();
            A = int.Parse(input[0]);
            B = int.Parse(input[1]);
            sb.Append($"{A + B}\n");
        }
        Console.WriteLine(sb.ToString());
    }
}