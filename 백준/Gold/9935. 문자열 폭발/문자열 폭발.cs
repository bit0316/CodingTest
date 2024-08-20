public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Stack<char> stack;
    static Stack<char> check;
    static string text;
    static string bomb;

    static void Main(string[] args)
    {
        text = SR.ReadLine();
        bomb = SR.ReadLine();

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        stack = new Stack<char>();
        for (int i = text.Length - 1; i >= 0; --i)
        {
            stack.Push(text[i]);
            CheckBomb();
        }
    }

    static void CheckBomb()
    {
        if (stack.Count < bomb.Length || stack.Peek() != bomb[0])
        {
            return;
        }

        check = new Stack<char>();

        int index;
        for (index = 0; index < bomb.Length; ++index)
        {
            check.Push(stack.Pop());
            if (check.Peek() != bomb[index])
            {
                break;
            }
        }

        if (index != bomb.Length)
        {
            while (check.Count > 0)
            {
                stack.Push(check.Pop());
            }
        }
    }
    
    static void PrintResult()
    {
        if (stack.Count == 0)
        {
            SW.Write("FRULA");
            return;
        }

        while (stack.Count > 0)
        {
            SW.Write(stack.Pop());
        }
    }
}