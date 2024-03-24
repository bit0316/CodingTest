public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int[] arr;

        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        PrintResult(arr);

        SR.Close();
        SW.Close();
    }

    static string GetRresult(int[] arr)
    {
        bool isAscend = false;
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            if (arr[i] == i + 1)
            {
                isAscend = true;
            }
            else if (arr[i] == size - i && !isAscend)
            {
                isAscend = false;
            }
            else
            {
                return "mixed";
            }
        }

        return isAscend ? "ascending" : "descending";
    }

    static void PrintResult(int[] arr)
    {
        SW.WriteLine(GetRresult(arr));

        SW.Flush();
    }
}