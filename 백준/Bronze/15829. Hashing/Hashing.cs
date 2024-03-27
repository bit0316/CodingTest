public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        long hash;
        int size;
        string input;

        size = int.Parse(SR.ReadLine());
        input = SR.ReadLine();

        hash = GetHash(input, size);
        PrintHash(hash);

        SR.Close();
        SW.Close();
    }

    static long GetHash(string input, int size)
    {
        long result = 0;
        long mult = 1;
        long mod = 1234567891;

        for (int i = 0; i < size; ++i)
        {
            result += (input[i] - 'a' + 1) * mult;
            result %= mod;
            mult = mult * 31 % mod;
        }

        return result;
    }

    static void PrintHash(long hash)
    {
        SW.WriteLine(hash);
    }
}