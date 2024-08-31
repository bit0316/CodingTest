public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;

        num = int.Parse(SR.ReadLine());
        GetResult(num);

        SR.Close();
        SW.Close();
    }

    static void GetResult(int num)
    {
        SW.Write($"{num} ");
        for (int i = 1; i < num / 2; ++i)
        {
            SW.Write($"{i} {num - i} ");
        }

        if (num > 1)
        {
            SW.Write($"{num / 2} ");
            if (num % 2 == 1)
            {
                SW.Write(num / 2 + 1);
            }
        }
    }
}