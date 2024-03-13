public class Program
{
    static void Main(string[] args)
    {
        int num;

        while (true)
        {
            num = int.Parse(Console.ReadLine());
            if (num == -1)
            {
                break;
            }

            PrintPerfectNum(num);
        }
    }

    static void PrintPerfectNum(int num)
    {
        int sum = 0;
        string result = "";

        for (int i = 1; i < num; ++i)
        {
            if (num % i == 0)
            {
                if (i > 1)
                {
                    result += " + ";
                }
                result += $"{i}";
                sum += i;
            }
        }

        result = sum == num ? $"{num} = {result}" : $"{num} is NOT perfect.";
        Console.WriteLine(result);
    }
}