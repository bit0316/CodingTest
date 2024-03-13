public class Program
{
    static void Main(string[] args)
    {
        int num;
        int index;
        string[] input;

        input = Console.ReadLine().Split();
        num = int.Parse(input[0]);
        index = int.Parse(input[1]);

        Console.WriteLine(GetIndexDivisor(num, index));
    }

    static int GetIndexDivisor(int num, int index)
    {
        int count = 0;

        for (int i = 1; i <= num; ++i)
        {
            if (num % i == 0)
            {
                count++;
                if (count == index)
                {
                    return i;
                }
            }
        }

        return 0;
    }
}