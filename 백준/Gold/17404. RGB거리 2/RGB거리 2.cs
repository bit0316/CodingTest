public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int COLOR_MAX = 3;
    static int COST_MAX = 1000;

    static int size;
    static int[][] cost;
    static int[,] arr;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());

        SetCost();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetCost()
    {
        cost = new int[size][];
        for (int i = 0; i < size; ++i)
        {
            cost[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        }
    }

    static int GetResult()
    {
        int min = int.MaxValue;

        for (int i = 0; i < COLOR_MAX; ++i)
        {
            arr = new int[size + 1, COLOR_MAX];
            for (int j = 0; j < COLOR_MAX; ++j)
            {
                arr[0, j] = i == j ? cost[0][j] : COST_MAX;
            }

            for (int j = 1; j < size; ++j)
            {
                arr[j, 0] = cost[j][0] + Math.Min(arr[j - 1, 1], arr[j - 1, 2]);
                arr[j, 1] = cost[j][1] + Math.Min(arr[j - 1, 2], arr[j - 1, 0]);
                arr[j, 2] = cost[j][2] + Math.Min(arr[j - 1, 0], arr[j - 1, 1]);
            }

            for (int j = 0; j < COLOR_MAX; ++j)
            {
                if (i != j)
                {
                    min = Math.Min(min, arr[size - 1, j]);
                }
            }
        }

        return min;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}