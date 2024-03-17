public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    
    static void Main(string[] args)
    {
        int max = 10;
        int[] arr = new int[max + 1];

        SetArray(arr);
        PrintArray(arr);

        sr.Close();
        sw.Close();
    }

    static void SetArray(int[] arr)
    {
        string input = sr.ReadLine();
        int size = input.Length;

        for (int i = 0; i < size; ++i)
        {
            arr[int.Parse(input[i].ToString())]++;
        }
    }

    static void PrintArray(int[] arr)
    {
        int size = arr.Length;

        for (int i = size - 1; i >= 0; --i)
        {
            while (arr[i] > 0)
            {
                sw.Write(i);
                arr[i]--;
            }
        }

        sw.Flush();
    }
}