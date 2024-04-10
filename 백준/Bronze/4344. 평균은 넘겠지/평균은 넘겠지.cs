public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int count;
        double avg;
        int[] arr;

        size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            count = 0;
            arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

            avg = (double)(arr.Sum() - arr[0]) / arr[0];
            for (int j = 1; j < arr.Length; ++j)
            {
                if (arr[j] > avg)
                {
                    count++;
                }
            }

            SW.WriteLine($"{(double)count / arr[0] * 100:0.000}%");
        }

        SR.Close();
        SW.Close();
    }
}