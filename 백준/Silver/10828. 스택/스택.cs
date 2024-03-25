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
                case "push":
                    Push(stack, int.Parse(input[1]));
                    break;
                case "pop":
                    PrintResult(Pop(stack));
                    break;
                case "size":
                    PrintResult(Size(stack));
                    break;
                case "empty":
                    PrintResult(Empty(stack));
                    break;
                case "top":
                    PrintResult(Top(stack));
                    break;
            }
        }

        SW.Flush();
        SR.Close();
        SW.Close();
    }

    static void Push(Stack<int> stack, int value)
    {
        stack.Push(value);
    }

    static int Pop(Stack<int> stack)
    {
        return stack.TryPop(out int value) ? value : -1;
    }

    static int Size(Stack<int> stack)
    {
        return stack.Count;
    }

    static bool IsEmpty(Stack<int> stack)
    {
        return Size(stack) == 0;
    }

    static int Empty(Stack<int> stack)
    {
        return IsEmpty(stack) ? 1 : 0;
    }

    static int Top(Stack<int> stack)
    {
        return stack.TryPeek(out int value) ? value : -1;
    }

    static void PrintResult(int num)
    {
        SW.WriteLine(num);
    }
}