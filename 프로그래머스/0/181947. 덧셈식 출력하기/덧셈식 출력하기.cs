using System;

public class Example
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        Console.WriteLine($"{a} + {b} = {a + b}");
    }
}