public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Stack<int> stack = new Stack<int>();
    static int[] input;
    static bool[] used;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        used = new bool[input[0] + 1];

        int index;
        for (int i = 0; i < input[1]; ++i)
        {
            index = int.Parse(SR.ReadLine());
            stack.Push(index);
        }

        while (stack.Count > 0)
        {
            index = stack.Pop();
            if (!used[index])
            {
                SW.WriteLine(index);
                used[index] = true;
            }
        }

        for (int i = 1; i <= input[0]; ++i)
        {
            if (!used[i])
            {
                SW.WriteLine(i);
            }
        }

        SR.Close();
        SW.Close();
    }
}