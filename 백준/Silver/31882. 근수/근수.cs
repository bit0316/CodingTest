public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static long count;
    static long result;
    static string input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        input = SR.ReadLine();

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        count = 0;
        result = 0;
        for (int i = 0; i < size; i++)
        {
            count = input[i] == '2' ? count + 1 : 0;
            result += count * (count + 1) / 2;
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}