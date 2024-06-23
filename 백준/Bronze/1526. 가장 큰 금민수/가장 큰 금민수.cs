public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;

        for (int i = int.Parse(SR.ReadLine()); i > 0; --i)
        {
            num = i;
            while (num > 0 && (num % 10 == 4 || num % 10 == 7))
            {
                num /= 10;
            }

            if (num == 0)
            {
                SW.WriteLine(i);
                break;
            }
        }

        SR.Close();
        SW.Close();
    }
}