public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        string input;

        size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine();
            PrintPalindrome(input);
        }

        SR.Close();
        SW.Close();
    }

    static void PrintPalindrome(string input)
    {
        int size = input.Length;
        int count = 0;

        for (int i = 0; i < size / 2 + 1; ++i)
        {
            count++;
            if (input[i] != input[size - i - 1])
            {
                SW.WriteLine($"0 {count}");
                return;
            }
        }
        SW.WriteLine($"1 {count}");
    }
}