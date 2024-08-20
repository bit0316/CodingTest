public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int NODE_SIZE = 10000;

    static int[] nodes;
    static int index;

    static void Main(string[] args)
    {
        SetNodes();
        PostOrder(0, index);

        SR.Close();
        SW.Close();
    }

    static void SetNodes()
    {
        string input;

        index = 0;
        nodes = new int[NODE_SIZE + 1];
        while (true)
        {
            input = SR.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            nodes[index++] = int.Parse(input);
        }
    }

    static void PostOrder(int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        int mid = start;
        while (mid < end)
        {
            mid++;
            if (nodes[start] < nodes[mid])
            {
                break;
            }
        }

        PostOrder(start + 1, mid);
        PostOrder(mid, end);
        SW.WriteLine(nodes[start]);
    }
}