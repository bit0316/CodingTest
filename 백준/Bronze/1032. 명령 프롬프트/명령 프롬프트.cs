public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static char[] result;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        result = SR.ReadLine().ToCharArray();

        for (int i = 1; i < size; ++i)
        {
            GetResult();
        }
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        string input = SR.ReadLine();

        for (int i = 0; i < input.Length; ++i)
        {
            if (input[i] != result[i])
            {
                result[i] = '?';
            }
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}