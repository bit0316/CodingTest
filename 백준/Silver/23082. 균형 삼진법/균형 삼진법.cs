public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;
        string result;

        num = int.Parse(SR.ReadLine());
        result = GetResult(num);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static string GetResult(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        bool flag = false;
        if (num < 0)
        {
            flag = true;
            num = -num;
        }

        string str = "";
        while (num > 0)
        {
            if (num % 3 == 1)
            {
                str = (flag ? 'T' : '1') + str;
                num /= 3;
            }
            else if (num % 3 == 0)
            {
                str = '0' + str;
                num /= 3;
            }
            else if (num % 3 == 2)
            {
                str = (flag ? '1' : 'T') + str;
                num = num / 3 + 1;
            }
        }

        return str;
    }

    static void PrintResult(string result)
    {
        SW.WriteLine(result);
    }
}