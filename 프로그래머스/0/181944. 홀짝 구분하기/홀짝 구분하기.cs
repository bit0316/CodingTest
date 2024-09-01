using System;

public class Example
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{num} is {num % 2 == 0 ? "even" : "odd"}");
    }
}