public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Queue<char> queue = new Queue<char>();
    static Queue<char> check = new Queue<char>();
    static string duck = "quack";

    static void Main(string[] args)
    {
        int result;
        string text;

        text = SR.ReadLine();

        SetStack(text);
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetStack(string text)
    {
        int size = text.Length;

        for (int i = 0; i < size; ++i)
        {
            queue.Enqueue(text[i]);
        }
    }

    static int GetResult()
    {
        int size;
        int count = 0;
        int index = 0;

        while (queue.Count > 0)
        {
            size = queue.Count;
            while (queue.Count > 0)
            {
                if (queue.Peek() == duck[index])
                {
                    queue.Dequeue();
                    index = index < duck.Length - 1 ? index + 1 : 0;
                    continue;
                }
                check.Enqueue(queue.Dequeue());
            }

            if (check.Count == size || index != 0)
            {
                return -1;
            }

            count++;
            while (check.Count > 0)
            {
                queue.Enqueue(check.Dequeue());
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}