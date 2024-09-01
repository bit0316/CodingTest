public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static double[][] pos;

    static void Main(string[] args)
    {
        double result;

        size = int.Parse(SR.ReadLine());

        SetPosition();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetPosition()
    {
        pos = new double[size][];
        for (int i = 0; i < size; ++i)
        {
            pos[i] = Array.ConvertAll(SR.ReadLine().Split(), double.Parse);
        }
    }

    static double GetResult()
    {
        double result = pos[size - 1][0] * pos[0][1] - pos[0][0] * pos[size - 1][1];

        for (int i = 1; i < size; ++i)
        {
            result += pos[i - 1][0] * pos[i][1] - pos[i][0] * pos[i - 1][1];
        }

        return Math.Abs(result) / 2;
    }

    static void PrintResult(double result)
    {
        SW.WriteLine(result.ToString("F1"));
    }
}