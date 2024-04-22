public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        long sum;
        int num;

        num = int.Parse(SR.ReadLine());
        
        sum = 0;
        for (int i = 1; i <= num; ++i)
        {
            sum += i * (num / i);
        }

        SW.WriteLine(sum);

        SR.Close();
        SW.Close();
    }
}