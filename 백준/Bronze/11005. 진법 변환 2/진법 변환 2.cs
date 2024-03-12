public class Program
{
    static void Main(string[] args)
    {
        int baseNum;
        int value;
        string[] input;
        string result;

        input = Console.ReadLine().Split();
        value = int.Parse(input[0]);
        baseNum = int.Parse(input[1]);

        result = GetResult(value, baseNum);
        Console.WriteLine(result);
    }

    static string GetResult(int value, int baseNum)
    {
        string result = "";
        char ch;
        int temp;

        while (value > 0)
        {
            temp = value % baseNum;
            ch = temp < 10 ? (char)(temp + '0') : (char)(temp + 'A' - 10);
            result += ch;
            value /= baseNum;
        }
        result = new string(result.Reverse().ToArray());

        return result;
    }
}