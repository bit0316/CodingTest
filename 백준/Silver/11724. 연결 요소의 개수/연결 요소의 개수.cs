public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int point;
    static int line;
    static bool[] visited;
    static bool[,] connected;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];

        visited = new bool[point + 1];
        connected = new bool[point + 1, point + 1];
        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            connected[input[0], input[1]] = true;
            connected[input[1], input[0]] = true;
        }

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult()
    {
        int count = 0;

        for (int i = 1; i <= point; ++i)
        {
            if (!visited[i])
            {
                count++;
                DFS(i);
            }
        }

        return count;
    }

    static void DFS(int depth)
    {
        if (visited[depth])
        {
            return;
        }

        visited[depth] = true;
        for (int i = 1; i <= point; ++i)
        {
            if (connected[depth, i] && !visited[i])
            {
                DFS(i);
            }
        }
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}