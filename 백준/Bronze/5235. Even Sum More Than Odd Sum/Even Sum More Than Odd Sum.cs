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
        string[] input = SR.ReadLine().Split();
        int sum = 0;
        int num;

        for (int i = int.Parse(input[0]); i > 0; --i)
        {
            num = int.Parse(input[i]);
            sum += num % 2 == 0 ? num : -num;
        }

        if (sum > 0)
        {
            SW.WriteLine("EVEN");
        }
        else if (sum < 0)
        {
            SW.WriteLine("ODD");
        }
        else
        {
            SW.WriteLine("TIE");
        }
    }
}