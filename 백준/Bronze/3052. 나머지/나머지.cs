public class Program
{
    static void Main(string[] args)
    {
        int size = 42;
        int times = 10;
        int count = 0;
        int[] arr;

        arr = new int[size];

        int remainder;
        for (int i = 0; i < times; ++i)
        {
            remainder = int.Parse(Console.ReadLine()) % 42;
            arr[remainder] = 1;
        }

        for (int i = 0; i < size; ++i)
        {
            if (arr[i] == 1)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}