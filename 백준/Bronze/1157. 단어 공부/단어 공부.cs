public class Program
{
    static void Main(string[] args)
    {
        int[] counts = new int[26];
        string input;

        input = Console.ReadLine().ToUpper();

        for (int i = 0; i < input.Length; ++i)
        {
            counts[input[i] - 'A']++;
        }

        int max = 0;
        char result = '?';
        for (int i = 0; i < counts.Length; ++i)
        {
            if (counts[i] > max)
            {
                max = counts[i];
                result = (char)('A' + i);
            }
            else if (counts[i] == max)
            {
                result = '?';
            }
        }

        Console.WriteLine(result);
    }
}