public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    static Dictionary<string, int> dict = new Dictionary<string, int>();
    static Dictionary<char, char> convert = new Dictionary<char, char>();

    static void Main(string[] args)
    {
        int size;
        long result;

        size = int.Parse(SR.ReadLine());
        result = GetResult(size);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult(int size)
    {
        string input;
        string newStr;
        int index;
        long result = 0;

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine();

            index = 0;
            newStr = "";
            convert.Clear();
            foreach (char ch in input)
            {
                if (!convert.ContainsKey(ch))
                {
                    convert[ch] = alphabet[index++];
                }
                newStr += convert[ch];
            }

            if (!dict.ContainsKey(newStr))
            {
                dict.Add(newStr, 1);
            }
            else
            {
                dict[newStr]++;
            }
        }

        foreach (int count in dict.Values)
        {
            result += (long)count * (count - 1) / 2;
        }

        return result;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}