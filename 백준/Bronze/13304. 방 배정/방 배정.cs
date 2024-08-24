public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int student;
    static int room;
    static int[] group;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        student = input[0];
        room = input[1];

        SetGroup();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetGroup()
    {
        group = new int[4];

        for (int i = 0; i < student; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (input[1] > 2)
            {
                group[input[0] * 2 + (input[1] - 3) / 2]++;
            }
        }
    }

    static int GetResult()
    {
        int count = (int)Math.Ceiling((double)(student - group.Sum()) / room);

        foreach (int size in group)
        {
            count += (int)Math.Ceiling((double)size / room);
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}