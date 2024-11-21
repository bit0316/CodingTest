public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Stack<int>[] stacks;
    static int[] input;

    const int LINE_MAX = 6;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        InitLines();
        result = GetResult(input[0], input[1]);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void InitLines()
    {
        stacks = new Stack<int>[LINE_MAX + 1];
        for (int i = 1; i <= LINE_MAX; ++i)
        {
            stacks[i] = new Stack<int>();
            stacks[i].Push(0);
        }
    }

    static int GetResult(int melody, int fret)
    {
        int count = 0;

        for (int i = 0; i < melody; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            while (stacks[input[0]].Peek() > input[1])
            {
                stacks[input[0]].Pop();
                count++;
            }

            if (stacks[input[0]].Peek() < input[1])
            {
                stacks[input[0]].Push(input[1]);
                count++;
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}