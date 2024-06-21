public class Program
{
    static void Main(string[] args)
    {
        int size;
        int[] input;

        size = int.Parse(Console.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            Console.WriteLine(input[0] + input[1]);
        }
    }
}