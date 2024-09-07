public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<long> list;
    static int ballCount;
    static int distanceCount;
    static long distance;
    static int[] input;

    static void Main(string[] args)
    {
        ballCount = int.Parse(SR.ReadLine());

        SetMap();

        distanceCount = int.Parse(SR.ReadLine());
        for (int i = 0; i < distanceCount; ++i)
        {
            distance = long.Parse(SR.ReadLine());
            GetResult(distance * distance);
        }

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        list = new List<long>();
        for (int i = 0; i < ballCount; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (Math.Abs(input[0]) <= input[1])
            {
                list.Add((long)input[0] * input[0] + (long)input[1] * input[1]);
            }
        }
        list.Sort();
    }

    static void GetResult(long distancePow)
    {
        int left = 0;
        int right = list.Count - 1;
        int mid;

        while (left <= right)
        {
            mid = (left + right) / 2;
            if (list[mid] <= distancePow)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        PrintResult(ballCount - list.Count, left, list.Count - left);
    }

    static void PrintResult(int foul, int infield, int homerun)
    {
        SW.WriteLine($"{foul} {infield} {homerun}");
    }
}