public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());
    static int MAX_SIZE = 1000001;
    
    static bool[] isComposite = new bool[MAX_SIZE];
    static int index = 2;

    static void Main(string[] args)
    {
        int num;
        string result;

        while (true)
        {
            num = int.Parse(SR.ReadLine());
            if (num == 0)
            {
                break;
            }

            SetComposite(num);
            result = GetGoldbach(num);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static void SetComposite(int num)
    {
        for (long i = index; i * i < MAX_SIZE; ++i)
        {
            if (!isComposite[i])
            {
                for (long j = i * i; j < MAX_SIZE; j += i)
                {
                    isComposite[j] = true;
                }
            }
        }

        index = num;
    }

    static string GetGoldbach(int num)
    {
        for (int i = 2; i <= num / 2; ++i)
        {
            if (!isComposite[i] && !isComposite[num - i])
            {
                return $"{num} = {i} + {num - i}";
            }
        }
        return "Goldbach's conjecture is wrong.";
    }

    static void PrintResult(string result)
    {
        SW.WriteLine(result);
    }
}