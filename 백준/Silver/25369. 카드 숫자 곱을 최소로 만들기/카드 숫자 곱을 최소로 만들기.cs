public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int multA;
    static int[] result;
    static bool isValid;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        GetResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        result = new int[size];
        multA = 1;

        foreach (int card in Array.ConvertAll(SR.ReadLine().Split(), int.Parse))
        {
            multA *= card;
        }

        DFS(0, 1);

        if (!isValid)
        {
            SW.Write(-1);
        }
    }

    static void DFS(int depth, int multB)
    {
        if (isValid)
        {
            return;
        }

        if (depth == size)
        {
            if (multB > multA)
            {
                isValid = true;
                PrintResult();
            }
            return;
        }

        for (int i = 1; i <= 9; ++i)
        {
            result[depth] = i;
            DFS(depth + 1, multB * i);
        }
    }

    static void PrintResult()
    {
        for (int i = 0; i < size; ++i)
        {
            SW.Write($"{result[i]} ");
        }
    }
}