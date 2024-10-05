public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] arr;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            SW.WriteLine(arr.Sum());
        }

        SR.Close();
        SW.Close();
    }
}