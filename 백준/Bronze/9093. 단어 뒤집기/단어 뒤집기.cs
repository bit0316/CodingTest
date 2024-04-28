public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        string[] input;

        size = int.Parse(SR.ReadLine());
        input = new string[size];

        for (int i = 0; i < size; ++i)
        {
            input[i] = SR.ReadLine();
            PrintReverseWords(input[i]);
        }

        SR.Close();
        SW.Close();
    }

    static void PrintReverseWords(string input)
    {
        string[] words = input.Split();

        for (int i = 0; i < words.Length; ++i)
        {
            SW.Write($"{new string(words[i].Reverse().ToArray())} ");
        }
        SW.WriteLine();
    }
}