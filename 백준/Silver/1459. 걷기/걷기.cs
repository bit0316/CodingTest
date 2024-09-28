public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static long row;
    static long col;
    static long timeW;
    static long timeS;

    static void Main(string[] args)
    {
        long result;
        long[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), long.Parse);
        row = input[0];
        col = input[1];
        timeW = input[2];
        timeS = input[3];

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult()
    {
        long timer = 0;
        long min = Math.Min(row, col);
        long remain;

        timer += timeW * 2 > timeS ? min * timeS : 2 * min * timeW;
        row -= min;
        col -= min;

        timer += (row % 2 + col % 2) * timeW;
        row -= row % 2;
        col -= col % 2;
        
        remain = 2 * (row / 2 + col / 2);
        timer += timeW > timeS ? remain * timeS : remain * timeW;

        return timer;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}