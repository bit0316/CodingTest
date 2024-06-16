public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int num;
        int count;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            count = 0;
            num = int.Parse(SR.ReadLine());
            while (num > 0)
            {
                if (num % 2 == 1)
                {
                    SW.Write($"{count} ");
                }
                num /= 2;
                count++;
            }
            SW.WriteLine();
        }

        SR.Close();
        SW.Close();
    }
}