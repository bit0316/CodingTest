public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int people;
        int[] arr;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        people = input[0] * input[1];

        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        foreach (int count in arr)
        {
            SW.Write($"{count - people} ");
        }

        SR.Close();
        SW.Close();
    }
}