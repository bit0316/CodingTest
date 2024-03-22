public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string input;

        while (true)
        {
            input = SR.ReadLine();
            if (input.Length == 1 && input[0] == '.')
            {
                break;
            }

            CheckVPS(input);
        }

        SW.Flush();
        SR.Close();
        SW.Close();
    }

    static void CheckVPS(string input)
    {
        Stack<char> stack = new Stack<char>();
        bool isValid = true;
        int countA = 0;
        int countB = 0;
        int size;

        size = input.Length;
        for (int i = 0; i < size; ++i)
        {
            if (input[i] == '(')
            {
                stack.Push(input[i]);
                countA++;
            }
            else if (input[i] == '[')
            {
                stack.Push(input[i]);
                countB++;
            }
            else if (input[i] == ')')
            {
                if (stack.TryPeek(out char ch) && ch == '(')
                {
                    stack.Pop();
                    countA--;
                    continue;
                }
                isValid = false;
                break;
            }
            else if (input[i] == ']')
            {
                if (stack.TryPeek(out char ch) && ch == '[')
                {
                    stack.Pop();
                    countB--;
                    continue;
                }
                isValid = false;
                break;
            }
        }

        PrintResult(isValid && countA == 0 && countB == 0);
    }

    static void PrintResult(bool isVPS)
    {
        string answer = isVPS ? "yes" : "no";
        SW.WriteLine(answer);
    }
}