public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int cost;
    static int price;
    static int[] trees;

    static void Main(string[] args)
    {
        long result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        cost = input[1];
        price = input[2];

        SetTrees();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetTrees()
    {
        trees = new int[size];
        for (int i = 0; i < size; ++i)
        {
            trees[i] = int.Parse(SR.ReadLine());
        }
    }

    static long GetResult()
    {
        long result = 0;
        long sum;
        int count;
        int cut;
        int total;
        int max = trees.Max();
        
        for (int i = 1; i <= max; ++i)
        {
            sum = 0;
            for (int j = 0; j < size; ++j)
            {
                if (trees[j] >= i)
                {
                    count = trees[j] / i;
                    cut = trees[j] % i == 0 ? trees[j] / i - 1 : trees[j] / i;
                    total = count * price * i - cut * cost;
                    sum += total > 0 ? total : 0;
                }
            }
            result = Math.Max(result, sum);
        }

        return result;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}