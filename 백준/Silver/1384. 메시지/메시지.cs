public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int group = 1;

        while (true)
        {
            size = int.Parse(SR.ReadLine());
            if (size == 0)
            {
                break;
            }
            GetResult(size, group++);
        }

        SR.Close();
        SW.Close();
    }

    static void GetResult(int size, int group)
    {
        string[][] paper = new string[size][];
        int count = 0;

        for (int i = 0; i < size; ++i)
        {
            paper[i] = SR.ReadLine().Split();
        }

        SW.WriteLine($"Group {group}");
        for (int i = 0; i < size; ++i)
        {
            for (int j = 1; j < size; ++j)
            {
                if (paper[i][j] == "N")
                {
                    SW.WriteLine($"{paper[(size + i - j) % size][0]} was nasty about {paper[i][0]}");
                    count++;
                }
            }
        }

        if (count == 0)
        {
            SW.WriteLine("Nobody was nasty");
        }
        SW.WriteLine();
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}