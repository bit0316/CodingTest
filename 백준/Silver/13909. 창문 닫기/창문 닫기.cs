public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;

        num = int.Parse(SR.ReadLine());
        PrintResult(num);

        SR.Close();
        SW.Close();
    }

    static int GetCount(int num)
    {
        int count = 0;

        for (int i = 1; i * i <= num; ++i)
        {
            count++;
        }

        return count;
    }

    static void PrintResult(int num)
    {
        SW.WriteLine(GetCount(num));

        SW.Flush();
    }
}