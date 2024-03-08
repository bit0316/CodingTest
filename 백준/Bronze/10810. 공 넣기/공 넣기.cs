public class Program
{
    static void Main(string[] args)
    {
        int size;
        int count;
        int[] arr;
        string[] input;

        input = Console.ReadLine().Split();
        size = int.Parse(input[0]);
        count = int.Parse(input[1]);
        arr = new int[size];
        

        int min;
        int max;
        int num;
        for (int i = 0; i < count; ++i)
        {
            input = Console.ReadLine().Split();
            min = int.Parse(input[0]);
            max = int.Parse(input[1]);
            num = int.Parse(input[2]);
            for (int j = min - 1; j < max; ++j)
            {
                arr[j] = num;
            }
        }

        for (int i = 0; i < size; ++i)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}