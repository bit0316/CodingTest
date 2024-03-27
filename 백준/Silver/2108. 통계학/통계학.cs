public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());
    static int MAX_ABSOLUTE_VALUE = 4000;

    static void Main(string[] args)
    {
        int size;
        int[] arr;

        size = int.Parse(SR.ReadLine());
        arr = new int[size];

        SetArray(arr, size);
        PrintMean(arr);
        PrintMedian(arr);
        PrintMode(arr);
        PrintRange(arr);

        SR.Close();
        SW.Close();
    }

    static void SetArray(int[] arr, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }
        Array.Sort(arr);
    }

    static void PrintMean(int[] arr)
    {
        SW.WriteLine(Convert.ToInt32(arr.Average()));
    }

    static void PrintMedian(int[] arr)
    {
        SW.WriteLine(arr[arr.Length / 2]);
    }

    static void PrintMode(int[] arr)
    {
        int mode;
        int[] counts = new int[MAX_ABSOLUTE_VALUE * 2 + 1];
        List<int> list = new List<int>();

        for (int i = 0; i < arr.Length; ++i)
        {
            counts[MAX_ABSOLUTE_VALUE + arr[i]]++;
        }
        mode = counts.Max();

        for (int i = 0; i < counts.Length; ++i)
        {
            if (counts[i] == mode)
            {
                list.Add(i - MAX_ABSOLUTE_VALUE);
            }
        }

        SW.WriteLine(list.Count > 1 ? list[1] : list[0]);
    }

    static void PrintRange(int[] arr)
    {
        SW.WriteLine(arr.Max() - arr.Min());
    }
}