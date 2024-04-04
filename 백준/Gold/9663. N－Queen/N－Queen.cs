public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int[] cols;
    static int size;
    static int count = 0;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        cols = new int[size + 1];

        NQueen(0);
        PrintResult(count);

        SR.Close();
        SW.Close();
    }

    static void NQueen(int depth)
    {
        if (!IsValid(depth))
        {
            return;
        }

        if (depth == size)
        {
            count++;
            return;
        }

        for (int i = 1; i <= size; ++i)
        {
            cols[depth + 1] = i;
            NQueen(depth + 1);
        }
    }

    static bool IsValid(int depth)
    {
        for (int i = 1; i < depth; ++i)
        {
            if (cols[depth] == cols[i] || Math.Abs(cols[depth] - cols[i]) == Math.Abs(depth - i))
            {
                return false;
            }
        }
        return true;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}