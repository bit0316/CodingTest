public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        CheckPalindrome();

        SW.Flush();
        SR.Close();
        SW.Close();
    }

    static void CheckPalindrome()
    {
        int size;
        string input;

        while (true)
        {
            input = Console.ReadLine();
            size = input.Length;

            if (input == "0")
            {
                break;
            }

            PrintPalindrome(input, size);
        }
    }

    static void PrintPalindrome(string input, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            if (input[i] != input[size - i - 1])
            {
                SW.WriteLine("no");
                return;
            }
        }

        SW.WriteLine("yes");
    }
}