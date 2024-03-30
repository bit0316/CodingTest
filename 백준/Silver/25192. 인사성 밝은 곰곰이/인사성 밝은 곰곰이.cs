public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int count;

        size = int.Parse(SR.ReadLine());

        count = GetResult(size);
        PrintResult(count);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int arr)
    {
        HashSet<string> hash = new HashSet<string>();
        string input;
        int count = 0;

        for (int i = 0; i < arr; ++i)
        {
            input = SR.ReadLine();
            if (input == "ENTER")
            {
                hash.Clear();
            }
            else if (!hash.Contains(input))
            {
                hash.Add(input);
                count++;
            }
        }

        return count;
    }

    static void PrintResult(long value)
    {
        SW.WriteLine(value);
    }
}