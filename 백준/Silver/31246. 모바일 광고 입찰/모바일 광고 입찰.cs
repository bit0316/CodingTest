public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int need;
    static List<int> list;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        need = input[1];

        SetArray();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        list = new List<int>();
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (input[1] > input[0])
            {
                list.Add(input[1] - input[0]);
            }
        }
        list.Sort();
    }

    static int GetResult()
    {
        int remain = need - (size - list.Count);

        return remain > 0 ? list[remain - 1] : 0;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}