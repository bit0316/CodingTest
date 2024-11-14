public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;
        string str;

        size = int.Parse(SR.ReadLine());
        str = SR.ReadLine();

        result = GetResult(size, str);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int size, string str)
    {
        int count = 0;
        int max = 0;

        for (int i = 0; i < size; ++i)
        {
            count += str[i] == '(' ? 1 : -1;
            max = Math.Max(max, Math.Abs(count));
        }

        return count == 0 ? max : -1;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}