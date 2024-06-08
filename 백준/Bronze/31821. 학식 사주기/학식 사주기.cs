public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int result;
    static int[] arr;
    
    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = new int[size + 1];

        for (int i = 1; i <= size; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            result += arr[int.Parse(SR.ReadLine())];
        }
        SW.WriteLine(result);

        SR.Close();
        SW.Close();
    }
}