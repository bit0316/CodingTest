public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int LIMIT_NUM = 10000;

    static Queue<(int, string)> queue = new Queue<(int, string)>();
    static bool[] visited;

    static void Main(string[] args)
    {
        int size;
        int[] input;
        string result;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            result = GetResult(input[0], input[1]);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static string GetResult(int numA, int numB)
    {
        int num = numA;
        string dslr = "";

        queue.Clear();
        visited = new bool[LIMIT_NUM];

        queue.Enqueue((numA, ""));
        while (queue.Count > 0 && num != numB)
        {
            (num, dslr) = queue.Dequeue();

            if (!visited[num])
            {
                queue.Enqueue((Double(num), dslr + "D"));
                queue.Enqueue((Subtract(num), dslr + "S"));
                queue.Enqueue((Left(num), dslr + "L"));
                queue.Enqueue((Right(num), dslr + "R"));
                visited[num] = true;
            }
        }

        return dslr;
    }

    static int Double(int num)
    {
        return (num * 2) % LIMIT_NUM;
    }

    static int Subtract(int num)
    {
        return num > 0 ? num - 1 : LIMIT_NUM - 1;
    }

    static int Left(int num)
    {
        return num / (LIMIT_NUM / 10) + (num * 10) % LIMIT_NUM;
    }

    static int Right(int num)
    {
        return num % 10 * (LIMIT_NUM / 10) + num / 10;
    }

    static void PrintResult(string result)
    {
        SW.WriteLine(result);
    }
}