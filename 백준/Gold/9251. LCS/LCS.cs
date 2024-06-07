public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static string strA;
    static string strB;
    static int[,] arr;

    static void Main(string[] args)
    {
        strA = SR.ReadLine();
        strB = SR.ReadLine();
        arr = new int[strA.Length + 1, strB.Length + 1];

        GetResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int row = strA.Length;
        int col = strB.Length;

        for (int i = 1; i <= row; ++i)
        {
            for (int j = 1; j <= col; ++j)
            {
                arr[i, j] = strA[i - 1] == strB[j - 1] ? arr[i - 1, j - 1] + 1 : Math.Max(arr[i - 1, j], arr[i, j - 1]);
            }
        }

        SW.WriteLine(arr[row, col]);
    }
}