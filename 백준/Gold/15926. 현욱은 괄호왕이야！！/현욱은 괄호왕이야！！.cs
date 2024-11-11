public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;
        string str;

        size = int.Parse(SR.ReadLine());
        str = SR.ReadLine();

        result = GetResult(size, str);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int size, string str)
    {
        Stack<int> stack = new Stack<int>();
        int max = 0;

        stack.Push(-1);
        for (int i = 0; i < size; ++i)
        {
            if (str[i] == '(')
            {
                stack.Push(i);
                continue;
            }

            stack.Pop();
            if (stack.Count > 0)
            {
                max = Math.Max(max, i - stack.Peek());
            }
            else
            {
                stack.Push(i);
            }
        }

        return max;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}