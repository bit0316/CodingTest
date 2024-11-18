public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int index = int.Parse(SR.ReadLine());

        SW.WriteLine((1 << index) - 1);
        GetResult(index);
        SW.WriteLine(index);

        SR.Close();
        SW.Close();
    }

    static void GetResult(int index)
    {
        Stack<(int, bool)> stack = new Stack<(int, bool)>();
        bool visited;

        stack.Push((index, false));
        while (stack.Count > 0)
        {
            (index, visited) = stack.Pop();
            if (index == 1)
            {
                SW.WriteLine(index);
            }
            else if (visited)
            {
                SW.WriteLine(index);
                stack.Push((index - 1, false));
            }
            else
            {
                stack.Push((index, true));
                stack.Push((index - 1, false));
            }
        }
    }
}