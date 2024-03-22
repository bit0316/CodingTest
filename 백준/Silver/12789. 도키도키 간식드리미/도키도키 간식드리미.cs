public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] order;
        bool isValid;

        size = int.Parse(SR.ReadLine());
        order = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        
        isValid = IsValid(order, size);
        PrintResult(isValid);

        SR.Close();
        SW.Close();
    }

    static bool IsValid(int[] order, int size)
    {
        Stack<int> stack = new Stack<int>();
        int index = 1;

        for (int i = 0; i < size; ++i)
        {
            if (order[i] != index)
            {
                stack.Push(order[i]);
            }
            else
            {
                index++;
                index += CheckStack(stack, index);
            }
        }

        return index == size + 1;
    }

    static int CheckStack(Stack<int> stack, int index)
    {
        int count = 0;

        while (stack.TryPeek(out int value) && value == index)
        {
            stack.Pop();
            count++;
            index++;
        }

        return count;
    }

    static void PrintResult(bool isValid)
    {
        string result = isValid ? "Nice" : "Sad";

        SW.WriteLine(result);

        SW.Flush();
    }
}