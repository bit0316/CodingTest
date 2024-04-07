public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int min = int.MaxValue;
    static int size;
    static int[,] arr;
    static bool[] visited;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = new int[size, size];
        visited = new bool[size];

        SetArray();
        DFS(0, 0);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        int[] input;

        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 0; j < size; ++j)
            {
                arr[i, j] = input[j];
            }
        }
    }

    static void DFS(int depth, int sub)
    {
        if (depth == size / 2)
        {
            int result = GetDiffValue();
            if (min > result)
            {
                min = result;
            }
            return;
        }

        for (int i = sub; i < size; ++i)
        {
            visited[i] = true;
            DFS(depth + 1, i + 1);
            visited[i] = false;
        }
    }

    static int GetDiffValue()
    {
        int start = 0;
        int link = 0;

        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                if (visited[i] && visited[j])
                {
                    start += arr[i, j];
                }
                if (!visited[i] && !visited[j])
                {
                    link += arr[i, j];
                }
            }
        }

        return Math.Abs(start - link);
    }

    static void PrintResult()
    {
        SW.WriteLine(min);
    }
}