public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] count;
    static int[] input;
    static (int, int)[] blocks;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        SetBlocks();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetBlocks()
    {
        blocks = new (int, int)[size];
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            blocks[i] = (input[0], input[1]);
        }
        blocks = blocks.OrderBy(x => x.Item1 * x.Item2).ToArray();
    }

    static void GetResult()
    {
        count = new int[size];
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < i; ++j)
            {
                if (blocks[j].Item1 <= blocks[i].Item1 && blocks[j].Item2 <= blocks[i].Item2 && count[i] < count[j])
                {
                    count[i] = count[j];
                }
            }
            count[i]++;
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(count.Max());
    }
}