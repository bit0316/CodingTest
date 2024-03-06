public class Program
{
    static void Main(string[] args)
    {
        int hour;
        int min;
        string[] input;

        input = Console.ReadLine().Split();
        hour = int.Parse(input[0]);
        min = int.Parse(input[1]);

        if (min < 45)
        {
            hour -= 1;
            min += 15;
        }
        else
        {
            min -= 45;
        }
        if (hour < 0)
        {
            hour += 24;
        }

        Console.WriteLine($"{hour} {min}");
    }
}