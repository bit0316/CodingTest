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
        string dancer = "ChongChong";
        string[] member;

        hash.Add(dancer);
        for (int i = 0; i < arr; ++i)
        {
            member = SR.ReadLine().Split();
            if (hash.Contains(member[0]))
            {
                hash.Add(member[1]);
            }
            else if (hash.Contains(member[1]))
            {
                hash.Add(member[0]);
            }
        }

        return hash.Count;
    }

    static void PrintResult(long value)
    {
        SW.WriteLine(value);
    }
}