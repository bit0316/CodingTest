public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        int[] arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int min = Math.Abs(arr[0] - arr[1]);

        for (int i = 1; i < size - 1; ++i)
        {
            min = Math.Min(min, Math.Abs(arr[i] - arr[i + 1]));
        }
        SW.WriteLine(min);

        SR.Close();
        SW.Close();
    }
}