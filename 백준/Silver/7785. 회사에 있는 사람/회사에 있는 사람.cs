public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        SortedSet<string> members = new SortedSet<string>();

        size = int.Parse(sr.ReadLine());

        SetMembers(members, size);
        PrintResult(members);

        sr.Close();
        sw.Close();
    }

    static void SetMembers(SortedSet<string> members, int size)
    {
        string[] input;

        for (int i = 0; i < size; ++i)
        {
            input = sr.ReadLine().Split();
            if (input[1] == "enter")
            {
                members.Add(input[0]);
            }
            else if (input[1] == "leave")
            {
                members.Remove(input[0]);
            }
        }
    }
    
    static void PrintResult(SortedSet<string> members)
    {
        foreach (string member in members.OrderBy(x => x).Reverse())
        {
            sw.WriteLine(member);
        }

        sw.Flush();
    }
}