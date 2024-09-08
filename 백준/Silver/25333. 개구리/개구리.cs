public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;
        int[] input;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            result = GetResult(input[0], input[1], input[2]);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult(int numA, int numB, int distance)
    {
        return distance / GetGCD(numA, numB);
    }

    static int GetGCD(int numA, int numB)
    {
        int remain = numA % numB;

        return remain != 0 ? GetGCD(numB, remain) : numB;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}