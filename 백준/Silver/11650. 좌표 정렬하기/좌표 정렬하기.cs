public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[][] arr;

        size = int.Parse(sr.ReadLine());
        arr = new int[size][];

        SetArray(arr);
        arr = SortArray(arr);
        PrintArray(arr);

        sr.Close();
        sw.Close();
    }

    static void SetArray(int[][] arr)
    {
        int posX;
        int posY;
        int size = arr.Length;
        string[] input;

        for (int i = 0; i < size; ++i)
        {
            input = sr.ReadLine().Split();
            posX = int.Parse(input[0]);
            posY = int.Parse(input[1]);
            arr[i] = new int[] { posX, posY };
        }
    }

    static int[][] SortArray(int[][] arr)
    {
        return arr.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();
    }

    static void PrintArray(int[][] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            sw.WriteLine($"{arr[i][0]} {arr[i][1]}");
        }

        sw.Flush();
    }
}