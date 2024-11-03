public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<char, char> RSP = new Dictionary<char, char>() { { 'R', 'S' }, { 'S', 'P' }, { 'P', 'R' } };

    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        string result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        list = SetList(input[0]);
        result = GetResult(input[1], input[2], list);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static List<string> SetList(int size)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < size; ++i)
        {
            list.Add(SR.ReadLine());
        }

        return list;
    }

    static string GetResult(int round, int gift, List<string> list)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        string prefix;

        for (int i = 1; i <= round; ++i)
        {
            dict.Clear();
            foreach (string s in list)
            {
                prefix = s.Substring(0, i);
                if (dict.ContainsKey(prefix))
                {
                    dict[prefix]++;
                }
                else
                {
                    dict[prefix] = 1;
                }
            }

            foreach (var item in dict)
            {
                if (item.Value <= gift)
                {
                    return item.Key;
                }
            }
        }

        return "";
    }

    static void PrintResult(string result)
    {
        if (string.IsNullOrEmpty(result))
        {
            SW.WriteLine(-1);
            return;
        }

        SW.WriteLine(result.Length);
        foreach (char ch in result)
        {
            SW.Write(RSP[ch]);
        }
    }
}