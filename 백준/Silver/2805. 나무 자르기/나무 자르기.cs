public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int length;
    static int[] trees;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        length = input[1];

        trees = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        BinarySearch();

        SR.Close();
        SW.Close();
    }

    static void BinarySearch()
    {
        long result;
        int min = 1;
        int max = trees.Max();
        int mid;

        while (min <= max)
        {
            result = 0;
            mid = (min + max) / 2;    
            for (int i = 0; i < size; ++i)
            {
                if (trees[i] > mid)
                {
                    result += trees[i] - mid;
                }
            }

            if (result >= length)
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        SW.WriteLine(max);
    }
}