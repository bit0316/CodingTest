public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        int size;
        string[] input;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();

            switch (input[0])
            {
                case "1":
                    PushStack(stack, int.Parse(input[1]));
                    break;
                case "2":
                    PrintResult(PopStack(stack));
                    break;
                case "3":
                    PrintResult(CountStack(stack));
                    break;
                case "4":
                    PrintResult(CheckEmpty(stack));
                    break;
                case "5":
                    PrintResult(CheckStack(stack));
                    break;
            }
        }

        SW.Flush();
        SR.Close();
        SW.Close();
    }

    static void PushStack(Stack<int> stack, int value)
    {
        stack.Push(value);
    }

    static int PopStack(Stack<int> stack)
    {
        return stack.TryPop(out int value) ? value : -1;
    }

    static int CountStack(Stack<int> stack)
    {
        return stack.Count;
    }

    static bool IsEmpty(Stack<int> stack)
    {
        return CountStack(stack) == 0;
    }

    static int CheckEmpty(Stack<int> stack)
    {
        return IsEmpty(stack) ? 1 : 0;
    }

    static int CheckStack(Stack<int> stack)
    {
        int value;
        
        if (IsEmpty(stack))
        {
            value = -1;
        }
        else
        {
            value = PopStack(stack);
            PushStack(stack, value);
        }

        return value;
    }

    static void PrintResult(int num)
    {
        SW.WriteLine(num);
    }
}