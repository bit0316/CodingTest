public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int count;
    static int[] arr;
    static int[] result;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        count = input[1];
        result = new int[size];

        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse).Distinct().ToArray();
        Array.Sort(arr);

        DFS(0, 0);

        SR.Close();
        SW.Close();
    }

    static void DFS(int depth, int sub)
    {
        if (depth == count)
        {
            for (int i = 0; i < count; ++i)
            {
                SW.Write($"{result[i]} ");
            }
            SW.WriteLine();
            return;
        }

        for (int i = sub; i < arr.Length; ++i)
        {
            result[depth] = arr[i];
            DFS(depth + 1, i);
        }
    }
}