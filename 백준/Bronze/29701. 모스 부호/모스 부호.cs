public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<string, char> morse = new Dictionary<string, char>()
    {
        { ".-", 'A' }, { "-...", 'B' }, { "-.-.", 'C' }, { "-..", 'D' }, { ".", 'E' }, { "..-.", 'F' },
        { "--.", 'G' }, { "....", 'H' }, { "..", 'I' }, { ".---", 'J' }, { "-.-", 'K' }, { ".-..", 'L' },
        { "--", 'M' }, { "-.", 'N' }, { "---", 'O' }, { ".--.", 'P' }, { "--.-", 'Q' }, { ".-.", 'R' },
        { "...", 'S' }, { "-", 'T' }, { "..-", 'U' }, { "...-", 'V' }, { ".--", 'W' }, { "-..-", 'X' },
        { "-.--", 'Y' }, { "--..", 'Z' }, { ".----", '1' }, { "..---", '2' }, { "...--", '3' }, { "....-", '4' },
        { ".....", '5' }, { "-....", '6' }, { "--...", '7' }, { "---..", '8' }, { "----.", '9' }, { "-----", '0' },
        { "--..--", ',' }, { ".-.-.-", '.' }, { "..--..", '?' }, { "---...", ':' }, { "-....-", '-' }, { ".--.-.", '@' }
    };

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        string[] input = SR.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            SW.Write(morse[input[i]]);
        }

        SR.Close();
        SW.Close();
    }
}