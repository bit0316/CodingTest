public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int hour;
        int minute;
        int second;
        int elapsed;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        hour = input[0];
        minute = input[1];
        second = input[2];
        elapsed = int.Parse(SR.ReadLine());

        second += elapsed;
        minute += second / 60;
        hour += minute / 60;

        second %= 60;
        minute %= 60;
        hour %= 24;

        SW.WriteLine($"{hour} {minute} {second}");

        SR.Close();
        SW.Close();
    }
}