public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<int> heap = new List<int>();
    static int size;
    static int input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        MinHeap();

        SR.Close();
        SW.Close();
    }

    static void MinHeap()
    {
        for (int i = 0; i < size; ++i)
        {
            input = int.Parse(SR.ReadLine());
            if (input == 0)
            {
                SW.WriteLine(Pop());
            }
            else
            {
                Push(input);
            }
        }
    }

    static void Push(int value)
    {
        int index;
        int parent;

        heap.Add(value);
        index = heap.Count - 1;
        parent = (index - 1) / 2;
        while (heap[parent] < heap[index])
        {
            (heap[index], heap[parent]) = (heap[parent], heap[index]);
            index = parent;
            parent = (index - 1) / 2;
        }
    }

    static int Pop()
    {
        int index = 0;
        int root;
        int child;
        int last;

        if (heap.Count == 0)
        {
            return 0;
        }

        root = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        last = heap.Count - 1;
        while (index < last)
        {
            child = index * 2 + 1;
            if (child < last && heap[child] < heap[child + 1])
            {
                child++;
            }

            if (child > last || heap[index] >= heap[child])
            {
                break;
            }

            (heap[index], heap[child]) = (heap[child], heap[index]);
            index = child;
        }

        return root;
    }
}