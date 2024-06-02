public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int length;
    static int[][] score = new int[2][];
    static int[][] sum = new int[2][];

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            length = int.Parse(SR.ReadLine());
            score[0] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            score[1] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            GetResult();
        }

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        sum[0] = new int[length + 1];
        sum[1] = new int[length + 1];
        sum[0][1] = score[0][0];
        sum[1][1] = score[1][0];
        for (int i = 2; i <= length; ++i)
        {
            sum[0][i] = Math.Max(sum[1][i - 1], sum[1][i - 2]) + score[0][i - 1];
            sum[1][i] = Math.Max(sum[0][i - 1], sum[0][i - 2]) + score[1][i - 1];
        }

        SW.WriteLine(Math.Max(sum[0][length], sum[1][length]));
    }
}