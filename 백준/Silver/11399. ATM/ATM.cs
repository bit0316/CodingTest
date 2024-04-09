public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;
        int[] times;

        size = int.Parse(SR.ReadLine());
        times = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        
        result = GetBestTime(size, times);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetBestTime(int size, int[] times)
    {
        int result = 0;

        times = times.OrderBy(x => x).ToArray();
        for (int i = 0; i < size; ++i)
        {
            result += times[i] * (size - i);
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}