public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            GetResult();
        }

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int m = input[0];
        int n = input[1];
        int x = input[2];
        int y = input[3];

        int day = x;
        while (day <= m * n)
        {
            if ((day - x) % m == 0 && (day - y) % n == 0)
            {
                SW.WriteLine(day);
                return;
            }
            day += m;
        }

        SW.WriteLine(-1);
    }
}