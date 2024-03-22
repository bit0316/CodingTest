public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        Queue<int> cards = new Queue<int>();
        int card;

        SetCards(cards);
        card = GetLastCard(cards);
        PrintResult(card);

        SR.Close();
        SW.Close();
    }

    static void SetCards(Queue<int> queue)
    {
        int size = int.Parse(SR.ReadLine());

        for (int i = 1; i <= size; ++i)
        {
            queue.Enqueue(i);
        }
    }

    static int GetLastCard(Queue<int> queue)
    {
        while (queue.Count > 1)
        {
            queue.Dequeue();
            queue.Enqueue(queue.Dequeue());
        }
        return queue.Dequeue();
    }

    static void PrintResult(int num)
    {
        SW.WriteLine(num);

        SW.Flush();
    }
}