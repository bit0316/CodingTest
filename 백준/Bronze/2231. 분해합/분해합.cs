public class Program
{
    static void Main(string[] args)
    {
        int result;
        string input;

        input = Console.ReadLine();

        result = GetBestValue(input);
        Console.WriteLine(result);
    }

    static int GetBestValue(string input)
    {
        int num = int.Parse(input);
        int size = input.Length * 9;
        int result = num;
        int value;

        for (int i = num - size; i < num - 1; ++i)
        {
            value = GetValue(i, size);
            if (value == num && i < result)
            {
                result = i;
            }
        }

        if (result == num)
        {
            return 0;
        }

        return result;
    }

    static int GetValue(int num, int size)
    {
        int result = num;

        for (int i = 0; i < size; ++i)
        {
            result += num % 10;
            num /= 10;
        }

        return result;
    }
}