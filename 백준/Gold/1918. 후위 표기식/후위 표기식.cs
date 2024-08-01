public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<char> list = new List<char>();
    static Stack<char> stack = new Stack<char>();
    static string input;

    static void Main(string[] args)
    {
        input = SR.ReadLine();

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int size = input.Length;

        for (int i = 0; i < size; ++i)
        {
            if (input[i] == '(')
            {
                stack.Push(input[i]);
            }
            else if (input[i] == '+' || input[i] == '-')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    list.Add(stack.Pop());
                }
                stack.Push(input[i]);
            }
            else if (input[i] == '*' || input[i] == '/')
            {
                while (stack.Count > 0 && stack.Peek() != '(' && stack.Peek() != '+' && stack.Peek() != '-')
                {
                    list.Add(stack.Pop());
                }
                stack.Push(input[i]);
            }
            else if (input[i] == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    list.Add(stack.Pop());
                }
                if (stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
            }
            else
            {
                list.Add(input[i]);
            }
        }
        while (stack.Count > 0)
        {
            list.Add(stack.Pop());
        }
    }

    static void PrintResult()
    {
        foreach (char ch in list)
        {
            SW.Write(ch);
        }
    }
}