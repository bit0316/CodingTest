public class Program
{
    static void Main(string[] args)
    {
        int num = 0;
        int baseNum;
        string text;
        string[] input;

        input = Console.ReadLine().Split();
        text = input[0].ToUpper();
        baseNum = int.Parse(input[1]);

        num = GetResult(text, baseNum);
        Console.WriteLine(num);
    }

    static int GetResult(string text, int baseNum)
    {
        int result = 0;
        int value;

        int length = text.Length;
        for (int i = 0; i < length; ++i)
        {
            value = text[i];
            value -= (text[i] >= 'A' && text[i] <= 'Z') ? 'A' - 10 : '0';
            result += value * CalBase(baseNum, length - 1 - i);
        }

        return result;
    }

    static int CalBase(int baseNum, int index)
    {
        int result = 1;
        for (int i = 0; i < index; ++i)
        {
            result *= baseNum;
        }
        return result;
    }
}