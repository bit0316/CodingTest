public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static string text;
    static int size;
    static bool[] visited;

    static void Main(string[] args)
    {
        text = SR.ReadLine();
        size = text.Length;

        visited = new bool[size];
        GetResult(0, size - 1);

        SR.Close();
        SW.Close();
    }

    static void GetResult(int start, int end)
    {
        if (start > end)
        {
            return;
        }

        int index = start;

        for (int i = start; i <= end; ++i)
        {
            if (text[index] > text[i])
            {
                index = i;
            }
        }

        visited[index] = true;
        PrintResult();

        GetResult(index + 1, end);
        GetResult(start, index - 1);
    }

    static void PrintResult()
    {
        for (int i = 0; i < size; ++i)
        {
            if (visited[i])
            {
                SW.Write(text[i]);
            }
        }
        SW.WriteLine();
    }
}