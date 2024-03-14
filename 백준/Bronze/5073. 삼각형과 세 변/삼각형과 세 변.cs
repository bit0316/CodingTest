public class Program
{
    static void Main(string[] args)
    {
        int size = 3;
        int[] lengths = new int[size];
        string[] input;

        int zeroCount;
        while (true)
        {
            zeroCount = 0;
            input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; ++i)
            {
                lengths[i] = int.Parse(input[i]);
                if (lengths[i] == 0)
                {
                    zeroCount++;
                }
            }

            if (zeroCount == 3)
            {
                break;
            }

            PrintTriangleType(lengths);
        }
    }

    static void PrintTriangleType(int[] lengths)
    {
        int count = 0;

        if (lengths[0] + lengths[1] > lengths[2] &&
            lengths[1] + lengths[2] > lengths[0] &&
            lengths[2] + lengths[0] > lengths[1])
        {
            if (lengths[0] == lengths[1])
            {
                count++;
            }
            if (lengths[1] == lengths[2])
            {
                count++;
            }
            if (lengths[2] == lengths[0])
            {
                count++;
            }

            if (count == 3)
            {
                Console.WriteLine("Equilateral");
            }
            else if (count == 1)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}