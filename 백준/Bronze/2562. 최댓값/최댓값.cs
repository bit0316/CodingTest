public class Program
{
    static void Main(string[] args)
    {
        int size = 9;
        int max = 0;
        int index = -1;
        int[] arr;
        
        arr = new int[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] > max)
            {
                max = arr[i];
                index = i + 1;
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(index);
    }
}