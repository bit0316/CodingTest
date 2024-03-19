public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        HashSet<string> arr = new HashSet<string>();

        SetArray(arr);
        PrintResult(arr);

        SR.Close();
        SW.Close();
    }

    static void SetArray(HashSet<string> arr)
    {
        string input = SR.ReadLine();
        int size = input.Length;
        int length = 0;

        for (int i = 0; i < size; ++i)
        {
            length++;
            for (int j = 0; j < size - length + 1; ++j)
            {
                arr.Add(input.Substring(j, length));
            }
        }
    }

    static void PrintResult(HashSet<string> arr)
    {
        SW.WriteLine(arr.Count);

        SW.Flush();
    }
}