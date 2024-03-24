public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        string[] tests;

        size = int.Parse(SR.ReadLine());
        tests = new string[size];

        SetTests(tests, size);
        PrintResult(tests);

        SR.Close();
        SW.Close();
    }

    static void SetTests(string[] tests, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            tests[i] = SR.ReadLine();
        }
    }

    static int GetScore(string test)
    {
        int size = test.Length;
        int score = 0;
        int combo = 0;

        for (int i = 0; i < size; ++i)
        {
            if (test[i] == 'O')
            {
                combo++;
            }
            else if (test[i] == 'X')
            {
                combo = 0;
            }
            score += combo;
        }

        return score;
    }

    static void PrintResult(string[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            SW.WriteLine(GetScore(arr[i]));
        }

        SW.Flush();
    }
}