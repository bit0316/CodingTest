public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] arr;
    static int[] result;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        GetResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        result = new int[size];

        for (int i = 0; i < size; ++i)
        {
            result[i] = 1;
            for (int j = 0; j < i; ++j)
            {
                if (arr[j] < arr[i] && result[i] <= result[j])
                {
                    result[i] = result[j] + 1;
                }
            }
        }

        int max = result[0];
        for (int i = 1; i < size; ++i)
        {
            max = Math.Max(max, result[i]);
        }
        SW.WriteLine(max);
    }
}