public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int min;
    static int max;
    static int size;
    static int result;
    static int[] arr;
    static int[] calc = new int[4];

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        calc = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        min = int.MaxValue;
        max = int.MinValue;
        result = arr[0];

        DFS(1);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void DFS(int depth)
    {
        if (depth == size)
        {
            if (min > result)
            {
                min = result;
            }
            if (max < result)
            {
                max = result;
            }
            return;
        }

        int temp = result;
        for (int i = 0; i < 4; ++i)
        {
            if (calc[i] > 0)
            {
                calc[i]--;
                result = GetCalculation(result, arr[depth], i);
                DFS(depth + 1);

                calc[i]++;
                result = temp;
            }
        }
    }

    static int GetCalculation(int numA, int numB, int operation)
    {
        switch (operation)
        {
            case 0:
                return numA + numB;
            case 1:
                return numA - numB;
            case 2:
                return numA * numB;
            case 3:
                return numA / numB;
            default:
                return default;
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(max);
        SW.WriteLine(min);
    }
}