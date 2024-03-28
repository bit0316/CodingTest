public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());
    static int MAX_NUM = 40;

    static void Main(string[] args)
    {
        int size;
        int index;
        int[] fibo;

        size = int.Parse(SR.ReadLine());

        fibo = new int[MAX_NUM + 1];
        SetFibo(fibo, MAX_NUM + 1);

        for (int i = 0; i < size; ++i)
        {
            index = int.Parse(SR.ReadLine());
            PrintResult(fibo, index);
        }

        SR.Close();
        SW.Close();
    }

    static void SetFibo(int[] fibo, int size)
    {
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < size; ++i)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
    }

    static void PrintResult(int[] fibo, int index)
    {
        int countZero = index < 2 ? 1 - index : fibo[index - 1];
        int countOne = index < 2 ? index : fibo[index];

        SW.WriteLine($"{countZero} {countOne}");
    }
}