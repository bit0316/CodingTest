public class Program
{
    static void Main(string[] args)
    {
        int size;
        double sum = 0f;
        int[] arr;
        string[] input;

        size = int.Parse(Console.ReadLine());
        arr = new int[size];
        input = Console.ReadLine().Split();

        int max = 0;
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
            if (max < arr[i])
            {
                max = arr[i];
            }
        }

        for (int i = 0; i < size; ++i)
        {
            sum += (double)arr[i] / max * 100;
        }

        Console.WriteLine(sum / size);
    }
}