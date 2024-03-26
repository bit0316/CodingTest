public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int count;

        size = int.Parse(SR.ReadLine());

        count = GetCountZero(size);
        PrintResult(count);

        SR.Close();
        SW.Close();
    }

    static int GetCountZero(int size)
    {
        int num;
        int count = 0;

        for (int i = 1; i <= size; ++i)
        {
            num = i;
            while (num % 5 == 0)
            {
                num /= 5;
                count++;
            }
        }

        return count;
    }

    static void PrintResult(int num)
    {
        SW.WriteLine(num);

        SW.Flush();
    }
}