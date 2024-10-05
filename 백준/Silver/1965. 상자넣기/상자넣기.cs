public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] box;
    static int[] arr;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());
        box = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        arr = new int[size + 1];

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult()
    {
        int max = 0;

        for (int i = 1; i <= size; ++i)
        {
            arr[i] = 1;
            for (int j = 1; j < i; ++j)
            {
                if (box[i - 1] > box[j - 1] && arr[i] < arr[j] + 1)
                {
                    arr[i] = arr[j] + 1;
                }
            }
            if (max < arr[i])
            {
                max = arr[i];
            }
        }

        return max;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}