public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        string result;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            result = GetResult();
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static string GetResult()
    {
        List<(float, string)> list = new List<(float, string)>();
        string[] times;
        int[] arr;
        float hour;
        float minute;
        float angle;

        times = SR.ReadLine().Split();
        foreach (string time in times)
        {
            arr = Array.ConvertAll(time.Split(':'), int.Parse);
            hour = arr[0] % 12 * 30f + arr[1] / 2f;
            minute = arr[1] * 6f;
            angle = Math.Abs(hour - minute);
            list.Add((Math.Min(angle, 360 - angle), time));
        }
        list = list.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();

        return list[2].Item2;
    }

    static void PrintResult(string result)
    {
        SW.WriteLine(result);
    }
}