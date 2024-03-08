public class Program
{
    static void Main(string[] args)
    {
        int size;
        int min;
        int max;
        int[] arr;
        string[] input;

        size = int.Parse(Console.ReadLine());
        arr = new int[size];
        input = Console.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }

        min = arr[0];
        max = arr[0];
        for (int i = 1; i < size; ++i)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            else if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine($"{min} {max}");
    }
}