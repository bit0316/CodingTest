public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());
    static int MAX_LEVEL = 5;

    static int size;
    static int result;
    static List<int>[] times = new List<int>[MAX_LEVEL + 1];
    static int[] count;
    static int[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        count = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        SetArray();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        for (int i = 0; i < times.Length; ++i)
        {
            times[i] = new List<int>();
        }

        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            times[input[0] - 1].Add(input[1]);
        }
    }

    static void GetResult()
    {
        int index;
        for (int i = 0; i < MAX_LEVEL; ++i)
        {
            index = 0;
            times[i].Sort();
            while (index < count[i])
            {
                if (index + 1 == count[i])
                {
                    result += times[i][index] + 60;
                }
                else
                {
                    result += times[i][index + 1];
                }

                index++;
            }
        }
        result -= 60;
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}