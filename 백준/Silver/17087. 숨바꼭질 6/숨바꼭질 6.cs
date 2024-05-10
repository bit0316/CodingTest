public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int point;
    static int[] arr;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        point = input[1];
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetDistance();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetDistance()
    {
        int distance;

        distance = Math.Abs(arr[0] - point);
        for (int i = 1; i < size; ++i)
        {
            distance = GetGCD(Math.Abs(arr[i] - point), distance);
        }

        return distance;
    }

    static int GetGCD(int numA, int numB)
    {
        int remain = numA % numB;

        return remain != 0 ? GetGCD(numB, remain) : numB;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}