public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        GetResult(input[0], input[1], input[2]);

        SR.Close();
        SW.Close();
    }

    static void GetResult(int a, int b, int h)
    {
        double height;
        double small;
        double big;

        if (a > b)
        {
            (a, b) = (b, a);
        }

        if (a == b)
        {
            SW.WriteLine(-1);
            return;
        }

        height = (double)b * h / (b - a);
        small = Math.Pow(height - h, 2) + Math.Pow(a, 2);
        big = Math.Pow(height, 2) + Math.Pow(b, 2);

        SW.WriteLine((big - small) * Math.PI);
    }
}