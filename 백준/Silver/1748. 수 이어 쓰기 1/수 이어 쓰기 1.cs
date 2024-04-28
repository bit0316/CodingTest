public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int result;
        string input;

        input = SR.ReadLine();

        result = GetLength(input);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetLength(string input)
    {
        int count = 0;
        int num = int.Parse(input);
        int size = input.Length;

        for (int i = size - 1; i > 0; --i)
        {
            count = count * 10 + 9 * i;
        }
        count += (num - (int)Math.Pow(10, size - 1) + 1) * size;

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}