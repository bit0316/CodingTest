public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<int>[] map;
    static int size;
    static int max;
    static int[] times;
    static int[] arr;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());
        
        SetMap();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        int[] input;

        map = new List<int>[size + 1];
        for (int i = 1; i <= size; ++i)
        {
            map[i] = new List<int>();
        }

        max = 0;
        times = new int[size + 1];
        for (int i = 1; i <= size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

            map[input[0]].Add(i);
            times[i] = input[1];
            max = Math.Max(max, input[0]);
        }
    }

    static int GetResult()
    {
        int result = 0;
        int diff;

        arr = new int[size + 1];
        for (int i = 1; i < max; ++i)
        {
            foreach (int posA in map[i])
            {
                foreach (int posB in map[i + 1])
                {
                    diff = posB - posA;
                    arr[posB] = Math.Max(arr[posB], arr[posA] + times[posA] + diff * diff);
                }
            }
        }

        foreach (int i in map[max])
        {
            result = Math.Max(result, arr[i] + times[i]);
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}