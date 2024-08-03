public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        int[] arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        long result = 0;

        Array.Sort(arr);
        for (int i = 0; i < size / 2; ++i)
        {
            result += 2 * (long)(arr[size - i - 1] - arr[i]) * (size - 2 * i - 1);
        }
        SW.WriteLine(result);

        SR.Close();
        SW.Close();
    }
}