public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        string[] arr;

        size = int.Parse(sr.ReadLine());
        arr = new string[size];

        SetArray(arr);
        arr = SortArray(arr);
        PrintArray(arr);

        sr.Close();
        sw.Close();
    }

    static void SetArray(string[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            arr[i] = sr.ReadLine();
        }
    }

    static string[] SortArray(string[] arr)
    {
        return arr.OrderBy(x => int.Parse(x.Split()[0])).ToArray();
    }

    static void PrintArray(string[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            sw.WriteLine(arr[i]);
        }

        sw.Flush();
    }
}