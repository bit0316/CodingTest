public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static string text;
    static int num;
    static int size;

    static void Main(string[] args)
    {
        List<char[]> result;

        text = SR.ReadLine();
        num = int.Parse(SR.ReadLine());
        size = text.Length;

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static List<char[]> GetResult()
    {
        List<char[]> list = new List<char[]>();
        List<char> part = new List<char>();

        for (int i = 0; i < num; i++)
        {
            part.Clear();
            for (int j = i; j < size; j += num)
            {
                part.Add(text[j]);
            }
            part.Sort();
            list.Add(part.ToArray());
        }

        return list;
    }

    static void PrintResult(List<char[]> list)
    {
        for (int i = 0; i < size; i++)
        {
            SW.Write(list[i % num][i / num]);
        }
    }
}