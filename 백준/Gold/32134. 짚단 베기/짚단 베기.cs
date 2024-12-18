public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int n;
    static long h, s;
    static List<int> list;

    static void Main(string[] args)
    {
        double result;
        string[] input;

        input = SR.ReadLine().Split();
        n = int.Parse(input[0]);
        h = long.Parse(input[1]);
        s = long.Parse(input[2]);

        list = new List<int>();
        input = SR.ReadLine().Split();
        for (int i = 0; i < n; ++i)
        {
            list.Add(int.Parse(input[i]));
        }

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }
    
    static double GetResult()
    {
        double power = 0;
        double height;
        double diff;

        if ((double)s / n * 2 > h)
        {
            height = (double)s / n;
            diff = h - height;
            for (int i = 0; i < n; ++i)
            {
                power += (h - (diff * 2)) * list[i];
            }
            power += GetPower(diff * 2);
        }
        else
        {
            power = GetPower((double)s / n * 2);
        }

        return power;
    }

    static double GetPower(double height)
    {
        double diff = height / n;
        double curHeight = diff;
        double volume = 0;
        double top = 0;
        double bottom = 0;
        double size;

        for (int i = 0; i < n; ++i)
        {
            size = curHeight / 2 * (i + 1) - volume;
            curHeight += diff;
            volume += size;
            top += size * list[i];
        }

        volume = 0;
        curHeight = diff;
        for (int i = n - 1; i >= 0; --i)
        {
            size = curHeight / 2 * (n - i) - volume;
            curHeight += diff;
            volume += size;
            bottom += size * list[i];
        }

        return Math.Min(top, bottom);
    }

    static void PrintResult(double result)
    {
        SW.WriteLine(result.ToString("F6"));
    }
}