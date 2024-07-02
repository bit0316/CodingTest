public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int length;
    static int result;
    static string input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        length = int.Parse(SR.ReadLine());
        input = SR.ReadLine();

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int count;

        result = 0;
        for (int i = 0; i < length - 2; ++i)
        {
            if (input[i] != 'I')
            {
                continue;
            }

            count = 0;
            while (i < length - 2 && input[i + 1] == 'O' && input[i + 2] == 'I')
            {
                count++;
                if (count >= size)
                {
                    result++;
                }
                i += 2;
            }
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}