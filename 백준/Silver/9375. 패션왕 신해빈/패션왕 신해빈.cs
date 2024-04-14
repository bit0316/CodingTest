public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<string, int> clothes = new Dictionary<string, int>();

    static void Main(string[] args)
    {
        int size;
        int count;
        int result;

        size = int.Parse(SR.ReadLine());
        
        for (int i = 0; i < size; ++i)
        {
            count = int.Parse(SR.ReadLine());
            SetClothes(count);
            result = GetCaseCount();
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static void SetClothes(int size)
    {
        string[] input;

        clothes.Clear();
        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            if (!clothes.ContainsKey(input[1]))
            {
                clothes[input[1]] = 1;
            }
            else
            {
                clothes[input[1]]++;
            }
        }
    }

    static int GetCaseCount()
    {
        int result = 1;

        foreach (int count in clothes.Values)
        {
            result *= count + 1;
        }

        return result - 1;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}