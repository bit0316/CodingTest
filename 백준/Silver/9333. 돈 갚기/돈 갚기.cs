public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_MONTH = 1200;

    static int size;
    static double[] arr;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            GetResult();
        }

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        double interest;
        double loan;
        double salary;
        double remain;

        arr = Array.ConvertAll(SR.ReadLine().Split(), double.Parse);
        interest = arr[0] + 100f;
        loan = arr[1];
        salary = arr[2];
        remain = loan;

        for (int i = 1; i <= MAX_MONTH; ++i)
        {
            remain *= interest;
            remain = remain - (int)remain >= 0.5f ? Math.Ceiling(remain) / 100f : Math.Truncate(remain) / 100f;
            remain -= salary;
            if (remain <= 0)
            {
                SW.WriteLine(i);
                return;
            }
        }

        SW.WriteLine("impossible");
    }
}