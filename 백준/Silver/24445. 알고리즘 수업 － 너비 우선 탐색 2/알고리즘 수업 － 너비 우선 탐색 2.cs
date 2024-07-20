public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int point;
    static int line;
    static int start;
    static int[] order;
    static int[] input;
    static List<int>[] map;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        point = input[0];
        line = input[1];
        start = input[2];

        SetArray();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        map = new List<int>[point + 1];
        for (int i = 1; i <= point; ++i)
        {
            map[i] = new List<int>();
        }

        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[input[0]].Add(input[1]);
            map[input[1]].Add(input[0]);
        }

        for (int i = 1; i <= point; ++i)
        {
            map[i] = map[i].OrderByDescending(x => x).ToList();
        }
    }

    static void GetResult()
    {
        Queue<int> queue = new Queue<int>();
        int count = 1;
        int index;

        order = new int[point + 1];

        queue.Enqueue(start);
        order[start] = count++;
        while (queue.Count > 0)
        {
            index = queue.Dequeue();

            for (int i = 0; i < map[index].Count; ++i)
            {
                if (order[map[index][i]] == 0)
                {
                    queue.Enqueue(map[index][i]);
                    order[map[index][i]] = count++;
                }
            }
        }
    }

    static void PrintResult()
    {
        for (int i = 1; i <= point; ++i)
        {
            SW.WriteLine(order[i]);
        }
    }
}