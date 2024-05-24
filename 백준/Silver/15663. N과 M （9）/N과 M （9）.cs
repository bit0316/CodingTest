public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int count;
    static int[] arr;
    static int[] order;
    static int[] input;
    static bool[] visited;

    static void Main(string[] args)
    {

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        count = input[1];
        order = new int[size];
        visited = new bool[size];

        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        Array.Sort(arr);

        DFS(0);

        SR.Close();
        SW.Close();
    }

    static void DFS(int depth)
    {
        if (depth == count)
        {
            for (int i = 0; i < count; ++i)
            {
                SW.Write($"{arr[order[i]]} ");
            }
            SW.WriteLine();
            return;
        }

        int temp = 0;
        for (int i = 0; i < size; ++i)
        {
            if (!visited[i] && temp != arr[i])
            {
                visited[i] = true;
                temp = arr[i];
                order[depth] = i;
                DFS(depth + 1);
                visited[i] = false;
            }
        }
    }
}