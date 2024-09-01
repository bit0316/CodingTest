using System;

public class Example
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string text = input[0];
        int count = Int32.Parse(input[1]);

        for (int i = 0; i < count; ++i)
        {
            Console.Write(text);
        }
    }
}