public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int sizeA;
        int sizeB;
        string[] input;
        Dictionary<int, string> dictIntStr = new Dictionary<int, string>();
        Dictionary<string, int> dictStrInt = new Dictionary<string, int>();

        input = sr.ReadLine().Split();
        sizeA = int.Parse(input[0]);
        sizeB = int.Parse(input[1]);

        SetDictionary(dictIntStr, dictStrInt, sizeA);
        PrintResult(dictIntStr, dictStrInt, sizeB);

        sr.Close();
        sw.Close();
    }

    static void SetDictionary(Dictionary<int, string> dictIntStr, Dictionary<string, int> dictStrInt, int size)
    {
        string input;

        for (int i = 1; i <= size; ++i)
        {
            input = sr.ReadLine();
            dictIntStr.Add(i, input);
            dictStrInt.Add(input, i);
        }
    }

    static void SearchDictionary(Dictionary<int, string> dictIntStr, Dictionary<string, int> dictStrInt)
    {
        string inputValue = sr.ReadLine();

        if (int.TryParse(inputValue, out int inputKey))
        {
            dictIntStr.TryGetValue(inputKey, out string outputValue);
            sw.WriteLine(outputValue);
        }
        else
        {
            dictStrInt.TryGetValue(inputValue, out int outputKey);
            sw.WriteLine(outputKey);
        }
    }

    static void PrintResult(Dictionary<int, string> dictIntStr, Dictionary<string, int> dictStrInt, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            SearchDictionary(dictIntStr, dictStrInt);
        }

        sw.Flush();
    }
}