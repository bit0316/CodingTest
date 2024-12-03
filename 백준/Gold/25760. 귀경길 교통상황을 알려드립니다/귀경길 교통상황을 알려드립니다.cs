public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<int>[] map;

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());

        SetMap(size);
        result = GetResult(size);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap(int size)
    {
        int[] input;

        map = new List<int>[size + 1];
        for (int i = 1; i <= size; ++i)
        {
            map[i] = new List<int>();
        }

        for (int i = 1; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[input[0]].Add(input[1]);
            map[input[1]].Add(input[0]);
        }
    }

    static int GetResult(int size)
    {
        Queue<int> queue = new Queue<int>();
        List<int> cars = new List<int>();

        int[] distance = new int[size + 1];
        int[] valid = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int count = valid.Count(c => c == 1);
        int start = 1;

        distance[start] = 1;
        queue.Enqueue(start);
        while (queue.Count > 0)
        {
            start = queue.Dequeue();
            if (valid[start - 1] == 1)
            {
                cars.Add(count - cars.Count - 1 + distance[start]);
            }

            foreach (int end in map[start])
            {
                if (distance[end] > 0)
                {
                    continue;
                }
                distance[end] = distance[start] + 1;
                queue.Enqueue(end);
            }
        }

        return cars.Max();
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}