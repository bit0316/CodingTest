public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int result = 0;

        for (int i = 3; i > 0; --i)
        {
            if (int.TryParse(SR.ReadLine(), out int num))
            {
                result = num + i;
            }
        }

        if (result % 15 == 0)
        {
            SW.WriteLine("FizzBuzz");
        }
        else if (result % 3 == 0)
        {
            SW.WriteLine("Fizz");
        }
        else if (result % 5 == 0)
        {
            SW.WriteLine("Buzz");
        }
        else
        {
            SW.WriteLine(result);
        }

        SR.Close();
        SW.Close();
    }
}