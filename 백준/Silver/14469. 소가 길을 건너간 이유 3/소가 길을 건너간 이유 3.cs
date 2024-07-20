public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<(int, int)> list = new List<(int, int)>();
    static int size;
    static int[] arr;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        SetList();
        GetResult();

        SR.Close();
        SW.Close();
    }

    static void SetList()
    {
        for (int i = 0; i < size; ++i)
        {
            arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            list.Add((arr[0], arr[1]));
        }
        list.Sort();
    }

    static void GetResult()
    {
        int time = 0;

        foreach (var item in list)
        {
            time = time < item.Item1 ? item.Item1 + item.Item2 : time + item.Item2;
        }

        SW.WriteLine(time);
    }
}