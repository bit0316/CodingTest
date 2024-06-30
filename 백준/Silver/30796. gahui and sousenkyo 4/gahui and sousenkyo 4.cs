public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int diff;
    static List<int> list = new List<int>();

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        diff = input[1];

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int count = size;

        while (count > 0)
        {
            for (int i = 0; i < diff; i++)
            {
                if (count > 0)
                {
                    list.Add(count);
                    count--;
                }
            }
            count -= diff;
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(list.Count);
        foreach (int num in list)
        {
            SW.WriteLine(num);
        }
    }
}