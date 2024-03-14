public class Program
{
    static void Main(string[] args)
    {
        int size = 3;
        int[] lengths = new int[size];
        int perimeter;
        string[] input;

        input = Console.ReadLine().Split();
        lengths[0] = int.Parse(input[0]);
        lengths[1] = int.Parse(input[1]);
        lengths[2] = int.Parse(input[2]);

        perimeter = GetPerimeter(lengths);
        Console.WriteLine(perimeter);
    }

    static int GetPerimeter(int[] lengths)
    {
        int total = 0;

        if (lengths[0] + lengths[1] <= lengths[2])
        {
            total = CalPerimeter(lengths[0], lengths[1]);
        }
        else if (lengths[1] + lengths[2] <= lengths[0])
        {
            total = CalPerimeter(lengths[1], lengths[2]);
        }
        else if (lengths[2] + lengths[0] <= lengths[1])
        {
            total = CalPerimeter(lengths[2], lengths[0]);
        }
        else
        {
            total = CalPerimeter(lengths[0], lengths[1], lengths[2]);
        }

        return total;
    }

    static int CalPerimeter(int lengthA, int lengthB)
    {
        return (lengthA + lengthB) * 2 - 1;
    }

    static int CalPerimeter(int lengthA, int lengthB, int lengthC)
    {
        return lengthA + lengthB + lengthC;
    }
}