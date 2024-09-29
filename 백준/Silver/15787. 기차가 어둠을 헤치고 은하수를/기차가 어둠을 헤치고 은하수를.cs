public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int train;
    static int command;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        train = input[0];
        command = input[1];

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult()
    {
        HashSet<int> set = new HashSet<int>();
        int[] arr = new int[train + 1];

        for (int i = 0; i < command; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (input[0] == 1)
            {
                arr[input[1]] |= 1 << (input[2] - 1);
            }
            else if (input[0] == 2)
            {
                arr[input[1]] &= ~(1 << (input[2] - 1));
            }
            else if (input[0] == 3)
            {
                arr[input[1]] &= ~(1 << 19);
                arr[input[1]] <<= 1;
            }
            else if (input[0] == 4)
            {
                arr[input[1]] &= ~1;
                arr[input[1]] >>= 1;
            }
        }

        for (int i = 1; i <= train; ++i)
        {
            set.Add(arr[i]);
        }

        return set.Count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}