public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;
        string[] input;

        input = SR.ReadLine().Split();
        num = GetVerificationNumber(input);
        PrintResult(num);

        SR.Close();
        SW.Close();
    }

    static int GetVerificationNumber(string[] input)
    {
        int result = 0;
        int size = input.Length;
        int[] nums = Array.ConvertAll(input, int.Parse);

        for (int i = 0; i < size; ++i)
        {
            result += nums[i] * nums[i];
        }
        result %= 10;

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);

        SW.Flush();
    }
}