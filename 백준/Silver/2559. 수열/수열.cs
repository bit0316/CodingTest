public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int[] input;
        int[] arr;
        int day;
        int count;
        int sum;
        int max;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        day = input[0];
        count = input[1];

        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        sum = 0;

        for (int i = 0; i < count; ++i)
        {
            sum += arr[i];
        }

        max = sum;
        for (int i = count; i < day; ++i)
        {
            sum += arr[i] - arr[i - count];
            max = Math.Max(max, sum);
        }

        SW.WriteLine(max);

        SR.Close();
        SW.Close();
    }
}