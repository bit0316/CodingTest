public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] arr;

        size = int.Parse(SR.ReadLine());

        arr = SetArray(size);
        PrintPushPop(arr, size);

        SR.Close();
        SW.Close();
    }

    static int[] SetArray(int size)
    {
        int[] arr = new int[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }

        return arr;
    }

    static void PrintPushPop(int[] arr, int size)
    {
        Stack<int> stack = new Stack<int>();
        Queue<char> result = new Queue<char>();
        int count = 1;

        for (int i = 0; i < size; ++i)
        {
            if (!stack.Contains(arr[i]))
            {
                for (int j = count; j <= arr[i]; ++j)
                {
                    stack.Push(j);
                    result.Enqueue('+');
                }
                count = arr[i] + 1;
            }
            if (stack.TryPeek(out int value) && value == arr[i])
            {
                stack.Pop();
                result.Enqueue('-');
            }
            else
            {
                SW.WriteLine("NO");
                return;
            }
        }

        while (result.TryDequeue(out char value))
        {
            SW.WriteLine(value);
        }

        SW.Flush();
    }
}