public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;
        int count;

        num = int.Parse(SR.ReadLine());

        count = GetCycleCount(num);
        PrintResult(count);

        SR.Close();
        SW.Close();
    }

    static int GetCycleCount(int num)
    {
        int numA;
        int numB;
        int temp = num;
        int count = 0;

        do
        {
            numA = num / 10;
            numB = num % 10;
            num = (numB * 10) + (numA + numB) % 10;
            count++;
        }
        while (num != temp);

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}