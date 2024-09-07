public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());

        result = GetResult(size);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int size)
    {
        Dictionary<int, int> dict;
        int price = 10000;
        int[] input;

        dict = new Dictionary<int, int>();
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (dict.ContainsKey(input[0]))
            {
                if (dict[input[0]] * input[2] < 0)
                {
                    price = input[0];
                }
                dict[input[0]] += input[1] * input[2];
            }
            else
            {
                dict.Add(input[0], input[1] * input[2]);
            }
        }

        return price;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}