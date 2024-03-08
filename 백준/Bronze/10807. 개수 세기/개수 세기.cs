public class Program
{
    static void Main(string[] args)
    {
        int[] arr;
        string[] input;
        int num;
        int count = 0;

        arr = new int[int.Parse(Console.ReadLine())];
        input = Console.ReadLine().Split();
        num = int.Parse(Console.ReadLine());

        for (int i = 0; i < arr.Length; ++i)
        {
            arr[i] = int.Parse(input[i]);
            if (num == arr[i])
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}