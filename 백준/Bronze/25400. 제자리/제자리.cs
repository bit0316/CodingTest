public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        int[] arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int result;

        result = GetResult(arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int[] arr)
    {
        int num = 1;
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            if (arr[i] == num)
            {
                num++;
            }
        }

        return size - num + 1;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}