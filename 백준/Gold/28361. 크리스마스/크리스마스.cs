public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        long num = long.Parse(SR.ReadLine());
        long count = num / 3;
        long index = 1;

        SW.WriteLine(num);
        if (num % 3 == 0)
        {
            SW.Write($"{1} ");
            for (int i = 1; i < count; ++i)
            {
                SW.Write($"{index + 2} {index + 1} {index + 3} ");
                index += 3;
            }
            SW.Write($"{index + 2} {index + 1} {1}");
        }
        else if (num % 3 == 1)
        {
            SW.Write($"{1} ");
            for (int i = 1; i <= count; ++i)
            {
                SW.Write($"{index + 2} {index + 1} {index + 3} ");
                index += 3;
            }
            SW.Write(1);
        }
        else if (num % 3 == 2)
        {
            SW.Write($"{1} ");
            SW.Write($"{index + 1} {index + 3} {index + 2} {index + 4} ");
            num -= 4;
            index += 4;
            for (int i = 1; i <= num / 3; ++i)
            {
                SW.Write($"{index + 2} {index + 1} {index + 3} ");
                index += 3;
            }
            SW.Write(1);
        }

        SR.Close();
        SW.Close();
    }
}