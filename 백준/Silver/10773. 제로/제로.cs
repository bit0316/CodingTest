public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        int size;
        int num;

        size = int.Parse(SR.ReadLine());
        ManageStack(stack, size);
        PrintResult(stack);

        SR.Close();
        SW.Close();
    }

    static void ManageStack(Stack<int> stack, int size)
    {
        int num;

        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(SR.ReadLine());

            if (num == 0)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(num);
            }
        }
    }

    static void PrintResult(Stack<int> stack)
    {
        int size = stack.Count;
        int count = 0;

        for (int i = 0; i < size; ++i)
        {
            count += stack.Pop();
        }
        SW.WriteLine(count);

        SW.Flush();
    }
}