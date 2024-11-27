public class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int count = str.Length;

        foreach (char ch in str)
        {
            if (ch == ':')
            {
                count++;
            }
            else if (ch == '_')
            {
                count += 5;
            }
        }

        Console.WriteLine(count);
    }
}