public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int[] result;
    static int numN;
    static int numM;

    static void Main(string[] args)
    {
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        numN = input[0];
        numM = input[1];
        result = new int[numM];

        DFS(0, 1);

        SR.Close();
        SW.Close();
    }

    static void DFS(int depth, int sub)
    {
        if (depth == numM)
        {
            for (int i = 0; i < numM; ++i)
            {
                SW.Write($"{result[i]} ");
            }
            SW.WriteLine();
            return;
        }

        for (int i = sub; i <= numN; ++i)
        {
            result[depth] = i;
            DFS(depth + 1, i);
        }
    }
}