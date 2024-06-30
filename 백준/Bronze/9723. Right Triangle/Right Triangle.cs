public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] arr;
    static string result;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        for (int i = 1; i <= size; ++i)
        {
            arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            Array.Sort(arr);

            result = arr[0] * arr[0] + arr[1] * arr[1] == arr[2] * arr[2] ? "YES" : "NO";
            SW.WriteLine($"Case #{i}: {result}");
        }

        SR.Close();
        SW.Close();
    }
}