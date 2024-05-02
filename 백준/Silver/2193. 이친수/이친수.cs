public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;
        long[] arr;
        
        num = int.Parse(Console.ReadLine());
        arr = new long[91];

        arr[1] = 1;
        arr[2] = 1;
        for (int i = 3; i <= num; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }

        SW.WriteLine(arr[num]);

        SR.Close();
        SW.Close();
    }
}