public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static (int, int)[] map;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());

        SetSchedule();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetSchedule()
    {
        map = new (int, int)[size];
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            map[i] = (input[0], input[1]);
        }
        map = map.OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToArray();
    }

    static int GetResult()
    {
        int count = 0;
        int time = 0;

        for (int i = 0; i < size; ++i)
        {
            if (time <= map[i].Item1)
            {
                time = map[i].Item2;
                count++;
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}