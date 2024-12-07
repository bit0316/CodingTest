public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        int[] init = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int[] target = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int[] change = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int result;

        result = GetResult(size, init, target, change);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int size, int[] init, int[] target, int[] change)
    {
        bool[] valid = new bool[2];
        int maxValue = 0;
        int value;

        for (int i = 0; i < size; ++i)
        {
            if ((init[i] - target[i]) % change[i] != 0)
            {
                return -1;
            }

            value = Math.Abs((init[i] - target[i]) / change[i]);
            maxValue = Math.Max(maxValue, value);
            valid[value % 2] = true;
        }

        return valid[0] && valid[1] ? -1 : maxValue;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}