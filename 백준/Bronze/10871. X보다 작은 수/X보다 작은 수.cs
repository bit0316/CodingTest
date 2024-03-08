public class Program
{
    static void Main(string[] args)
    {
        int[] arr;
        string[] input;
        int size;
        int pivot;

        input = Console.ReadLine().Split();
        size = int.Parse(input[0]);
        pivot = int.Parse(input[1]);
        arr = new int[size];

        input = Console.ReadLine().Split();
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
            if (arr[i] < pivot)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}