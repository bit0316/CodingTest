public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] arr;
        int[] comp;

        size = int.Parse(sr.ReadLine());
        arr = new int[size];

        SetArray(arr);
        comp = CompressArray(arr);
        PrintArray(comp);

        sr.Close();
        sw.Close();
    }

    static void SetArray(int[] arr)
    {
        int size = arr.Length;
        string[] input = sr.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }
    }

    static int[] CompressArray(int[] arr)
    {
        int size = arr.Length;
        int[][] temp = new int[size][];
        int[] result = new int[size];
        int count = 0;

        for (int i = 0; i < size; ++i)
        {
            temp[i] = new int[] { i, arr[i] };
        }

        arr = arr.OrderBy(x => x).ToArray();
        temp = temp.OrderBy(x => x[1]).ToArray();
        for (int i = 1; i < size; ++i)
        {
            if (arr[i - 1] < arr[i])
            {
                count++;
            }
            temp[i][1] = count;
        }
        temp[0][1] = 0;

        temp = temp.OrderBy(x => x[0]).ToArray();
        for (int i = 0; i < size; ++i)
        {
            result[i] = temp[i][1];
        }

        return result;
    }

    static void PrintArray(int[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            sw.Write($"{arr[i]} ");
        }

        sw.Flush();
    }
}