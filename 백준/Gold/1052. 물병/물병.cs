public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int liter;
        int limit;
        int[] input;
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        liter = input[0];
        limit = input[1];

        result = GetResult(liter, limit);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int liter, int limit)
    {
        string bin = Convert.ToString(liter, 2);
        int bottle = bin.Count(x => x == '1');
        int count = 0;
        int index;

        while (bottle > limit)
        {
            index = 0;
            while (bin[bin.Length - index - 1] == '0')
            {
                index++;
            }
            count += (int)Math.Pow(2, index);
            bin = Convert.ToString(liter + count, 2);
            bottle = bin.Count(x => x == '1');
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}