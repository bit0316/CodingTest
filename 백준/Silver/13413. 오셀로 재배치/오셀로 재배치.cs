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
        int size = int.Parse(SR.ReadLine());
        string strA = SR.ReadLine();
        string strB = SR.ReadLine();
        int wb = 0;
        int bw = 0;

        for (int i = 0; i < size; ++i)
        {
            if (strA[i] == 'W' && strB[i] == 'B')
            {
                wb++;
            }
            else if (strA[i] == 'B' && strB[i] == 'W')
            {
                bw++;
            }
        }

        return Math.Max(wb, bw);
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}