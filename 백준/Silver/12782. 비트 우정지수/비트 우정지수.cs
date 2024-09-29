public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            result = GetResult();
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult()
    {
        string[] input = SR.ReadLine().Split();
        string strA = input[0];
        string strB = input[1];
        int size = strA.Length;
        int bitOn = 0;
        int bitOff = 0;

        for (int i = 0; i < size; ++i)
        {
            if (strA[i] == '0' && strB[i] == '1')
            {
                bitOn++;
            }
            else if (strA[i] == '1' && strB[i] == '0')
            {
                bitOff++;
            }
        }

        return Math.Max(bitOn, bitOff);
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}