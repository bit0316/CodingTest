public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int FIBO_SIZE = 45;

    static void Main(string[] args)
    {
        int size;
        int num;
        int[] fibo;

        fibo = SetFibo(FIBO_SIZE);

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(SR.ReadLine());
            GetResult(FIBO_SIZE, num, fibo);
        }

        SR.Close();
        SW.Close();
    }
    
    static int[] SetFibo(int size)
    {
        int[] fibo = new int[size];

        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < size; ++i)
        {
            fibo[i] = fibo[i - 2] + fibo[i - 1];
        }

        return fibo;
    }

    static void GetResult(int size, int num, int[] fibo)
    {
        Stack<int> stack = new Stack<int>();

        for (int i = size - 1; i > 0; --i)
        {
            if (num >= fibo[i])
            {
                stack.Push(fibo[i]);
                num -= fibo[i];
            }
        }

        while (stack.Count > 0)
        {
            SW.Write(stack.Pop() + " ");
        }
        SW.WriteLine();
    }
}