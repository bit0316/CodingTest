public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] orders;

        size = int.Parse(SR.ReadLine());
        orders = new int[size];

        for (int i = 0; i < size; ++i)
        {
            orders[i] = GetPrintOrder();
        }
        PrintResult(orders);

        SR.Close();
        SW.Close();
    }

    static int GetPrintOrder()
    {
        int size;
        int order;
        int count = 0;
        int index = -1;
        int priority = -1;
        int[] priorities;
        string[] input;
        Queue<int> prioritiesOrder = new Queue<int>();
        Queue<int> prioritiesQueue = new Queue<int>();

        input = SR.ReadLine().Split();
        size = int.Parse(input[0]);
        order = int.Parse(input[1]);
        priorities = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        for (int i = 0; i < size; ++i)
        {
            prioritiesOrder.Enqueue(i);
            prioritiesQueue.Enqueue(priorities[i]);
        }

        Array.Sort(priorities);
        Array.Reverse(priorities);

        while (true)
        {
            index = prioritiesOrder.Dequeue();
            priority = prioritiesQueue.Dequeue();

            if (priority != priorities[count])
            {
                prioritiesOrder.Enqueue(index);
                prioritiesQueue.Enqueue(priority);
                continue;
            }
            count++;

            if (index == order)
            {
                break;
            }
        }

        return count;
    }

    static void PrintResult(int[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            SW.WriteLine(arr[i]);
        }

        SW.Flush();
    }
}