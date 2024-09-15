public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int DIV_SIZE = 1000000007;
    static List<int>[] list;
    static int point;
    static int line;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];

        SetList();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetList()
    {
        list = new List<int>[point + 1];
        for (int i = 1; i <= point; ++i)
        {
            list[i] = new List<int>();
        }

        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            list[input[0]].Add(input[1]);
            list[input[1]].Add(input[0]);
        }
    }

    static int GetResult()
    {
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[point + 1];
        long result = 1;
        int count;
        int index;

        for (int i = 1; i <= point; ++i)
        {
            if (!visited[i])
            {
                count = 1;
                visited[i] = true;
                queue.Enqueue(i);
                while (queue.Count > 0)
                {
                    index = queue.Dequeue();
                    foreach (int friend in list[index])
                    {
                        if (!visited[friend])
                        {
                            count++;
                            visited[friend] = true;
                            queue.Enqueue(friend);
                        }
                    }
                }
                result *= count;
                result %= DIV_SIZE;
            }
        }

        return (int)result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}