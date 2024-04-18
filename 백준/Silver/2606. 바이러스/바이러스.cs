public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Queue<int> queue = new Queue<int>();
    static bool[] isVirus;
    static bool[,] isConnect;
    static int size;
    static int[] input;

    static void Main(string[] args)
    {
        int network;
        int result;

        size = int.Parse(SR.ReadLine());
        network = int.Parse(SR.ReadLine());

        isVirus = new bool[size + 1];
        isConnect = new bool[size + 1, size + 1];
        for (int i = 1; i <= network; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            isConnect[input[0], input[1]] = true;
            isConnect[input[1], input[0]] = true;
        }

        result = GetResult(1);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int start)
    {
        int count = 0;
        int index;

        isVirus[start] = true;
        queue.Enqueue(start);
        while (queue.Count > 0)
        {
            index = queue.Dequeue();
            for (int i = 1; i <= size; ++i)
            {
                if (isConnect[index, i] && !isVirus[i])
                {
                    isVirus[i] = true;
                    queue.Enqueue(i);
                    count++;
                }
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}