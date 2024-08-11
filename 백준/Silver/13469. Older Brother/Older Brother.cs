public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;
        bool valid;

        num = int.Parse(SR.ReadLine());
        valid = IsValid(num);
        PrintResult(valid);

        SR.Close();
        SW.Close();
    }

    static bool IsValid(int num)
    {
        if (num < 2)
        {
            return false;
        }

        long power;

        for (int i = 2; i * i <= num; ++i)
        {
            if (IsPrime(i))
            {
                power = i;
                while (power <= num)
                {
                    if (power == num)
                    {
                        return true;
                    }
                    power *= i;
                }
            }
        }

        return IsPrime(num);
    }

    static bool IsPrime(long num)
    {
        if (num <= 1)
        {
            return false;
        }
        else if (num == 2 || num == 3)
        {
            return true;
        }
        else if (num % 2 == 0 || num % 3 == 0)
        {
            return false;
        }

        for (long i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void PrintResult(bool isValid)
    {
        if (isValid)
        {
            SW.WriteLine("yes");
        }
        else
        {
            SW.WriteLine("no");
        }
    }
}