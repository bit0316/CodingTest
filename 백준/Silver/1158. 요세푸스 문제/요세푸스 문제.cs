public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Queue<int> circle = new Queue<int>();
    static Queue<int> result = new Queue<int>();
    static int size;
    static int order;

    static void Main(string[] args)
    {
        string[] input;

        input = SR.ReadLine().Split();
        size = int.Parse(input[0]);
        order = int.Parse(input[1]);

        SetCircle();
        GetJosephus();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetCircle()
    {
        for (int i = 1; i <= size; ++i)
        {
            circle.Enqueue(i);
        }
    }

    static void GetJosephus()
    {
        while (circle.Count > 0)
        {
            for (int i = 0; i < order - 1; ++i)
            {
                circle.Enqueue(circle.Dequeue());
            }
            result.Enqueue(circle.Dequeue());
        }
    }

    static void PrintResult()
    {
        SW.Write("<");
        for (int i = 0; i < size - 1; ++i)
        {
            SW.Write($"{result.Dequeue()}, ");
        }
        SW.Write(result.Dequeue());
        SW.WriteLine(">");
    }
}