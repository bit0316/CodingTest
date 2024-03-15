public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    
    static void Main(string[] args)
    {
        int max = 10000;
        int[] arr = new int[max + 1];

        SetArray(arr);
        PrintArray(arr);

        sr.Close();
        sw.Close();
    }

    static void SetArray(int[] arr)
    {
        int num;
        int size;
        
        size = int.Parse(sr.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(sr.ReadLine());
            arr[num]++;
        }
    }

    static void PrintArray(int[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            while (arr[i] > 0)
            {
                sw.WriteLine(i);
                arr[i]--;
            }
        }

        sw.Flush();
    }
}