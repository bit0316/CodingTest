public class Program
{
    static void Main(string[] args)
    {
        int forward;
        int backward;
        int length;
        int result;
        string[] input;

        input = Console.ReadLine().Split();
        forward = int.Parse(input[0]);
        backward = int.Parse(input[1]);
        length = int.Parse(input[2]);

        result = GetDays(forward, backward, length);
        Console.WriteLine(result);
    }

    static int GetDays(int forward, int backward, int length)
    {
        int days = 1;
        int remain;
        int move;

        remain = length - forward;
        move = forward - backward;

        if (remain > 0 && move != 0)
        {
            days += remain / move;
            if (remain % move > 0)
            {
                days++;
            }
        }

        return days;
    }
}