public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        int result;

        for (int i = 1; i <= size; ++i)
        {
            result = GetResult();
            PrintResult(i, result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult()
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int line = int.Parse(SR.ReadLine());
        int count = 0;
        int[] input;

        for (int i = 0; i < line; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            foreach (var item in dict)
            {
                if ((input[0] > item.Key && input[1] < item.Value) ||
                    (input[0] < item.Key && input[1] > item.Value))
                {
                    count++;
                }
            }
            dict.Add(input[0], input[1]);
        }

        return count;
    }

    static void PrintResult(int index, int result)
    {
        SW.WriteLine($"Case #{index}: {result}");
    }
}