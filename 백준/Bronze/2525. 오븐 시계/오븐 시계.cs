public class Program
{
    static void Main(string[] args)
    {
        int hour;
        int min;
        int timer;
        string[] input;

        input = Console.ReadLine().Split();
        hour = int.Parse(input[0]);
        min = int.Parse(input[1]);
        timer = int.Parse(Console.ReadLine());

        min += timer;
        if (min >= 60)
        {
            hour += min / 60;
            hour %= 24;
            min %= 60;
        }

        Console.WriteLine($"{hour} {min}");
    }
}