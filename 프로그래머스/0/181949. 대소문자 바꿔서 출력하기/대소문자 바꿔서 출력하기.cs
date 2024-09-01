using System;

public class Example
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int size = input.Length;
        
        for (int i = 0; i < size; ++i)
        {
            Console.Write(char.IsLower(input[i]) ? char.ToUpper(input[i]) : char.ToLower(input[i]));
        }
    }
}