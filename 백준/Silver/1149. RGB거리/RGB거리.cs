public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[][] house;
    static int[][] cost;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());
        house = new int[size][];
        cost = new int[size][];

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult()
    {
        house[0] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        cost[0] = house[0];
        for (int i = 1; i < size; ++i)
        {
            cost[i] = new int[3];
            house[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            cost[i][0] = Math.Min(cost[i - 1][1], cost[i - 1][2]) + house[i][0];
            cost[i][1] = Math.Min(cost[i - 1][2], cost[i - 1][0]) + house[i][1];
            cost[i][2] = Math.Min(cost[i - 1][0], cost[i - 1][1]) + house[i][2];
        }

        return Math.Min(Math.Min(cost[size - 1][0], cost[size - 1][1]), cost[size - 1][2]);
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}