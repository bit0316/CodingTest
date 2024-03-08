public class Program
{
    static void Main(string[] args)
    {
        int size = 30;
        int count = 28;
        int[] arr;

        arr = new int[size];

        for (int i = 0; i < count; ++i)
        {
            arr[int.Parse(Console.ReadLine()) - 1] = 1;
        }

        for (int i = 0; i < size; ++i)
        {
            if (arr[i] == 0)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}