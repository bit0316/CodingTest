public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        int size;
        int length;
        string[] input;

        input = SR.ReadLine().Split();
        size = int.Parse(input[0]);
        length = int.Parse(input[1]);

        SetDictionary(dictionary, size, length);
        PrintResult(dictionary);

        SR.Close();
        SW.Close();
    }

    static void SetDictionary(Dictionary<string, int> dictionary, int size, int length)
    {
        string input;

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine();
            if (input.Length >= length && !dictionary.TryAdd(input, 1))
            {
                dictionary[input]++;
            }
        }
    }

    static void PrintResult(Dictionary<string, int> dictionary)
    {
        Dictionary<string, int> sorted = new Dictionary<string, int>();

        sorted = dictionary.OrderByDescending(x => x.Value)
            .ThenByDescending(x => x.Key.Length)
            .ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

        foreach (var word in sorted)
        {
            SW.WriteLine(word.Key);
        }
    }
}