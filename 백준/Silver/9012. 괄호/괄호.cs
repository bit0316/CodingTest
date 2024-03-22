public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        Stack<bool>[] stacks;

        size = int.Parse(SR.ReadLine());
        stacks = new Stack<bool>[size];

        ManageStacks(stacks, size);
        PrintResult(stacks);

        SR.Close();
        SW.Close();
    }

    static void ManageStacks(Stack<bool>[] stacks, int size)
    {
        string input;

        for (int i = 0; i < size; ++i)
        {
            stacks[i] = new Stack<bool>();
            input = SR.ReadLine();

            for (int j = 0; j < input.Length; ++j)
            {
                if (input[j] == '(')
                {
                    stacks[i].Push(false);
                }
                else if (input[j] == ')')
                {
                    stacks[i].Push(true);
                }
            }
        }
    }

    static bool IsVPS(Stack<bool> stack)
    {
        int count = 0;
        int size = stack.Count;

        for (int i = 0; i < size; ++i)
        {
            count += stack.Pop() ? 1 : -1;
            if (count < 0)
            {
                return false;
            }
        }

        return count == 0;
    }

    static void PrintResult(Stack<bool>[] stacks)
    {
        int size = stacks.Length;
        string answer;

        for (int i = 0; i < size; ++i)
        {
            answer = IsVPS(stacks[i]) ? "YES" : "NO";
            SW.WriteLine(answer);
        }

        SW.Flush();
    }
}