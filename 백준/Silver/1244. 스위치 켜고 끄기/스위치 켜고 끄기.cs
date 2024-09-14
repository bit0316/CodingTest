public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int PRINT_SIZE = 20;
    static int size;
    static int[] arr;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int people = int.Parse(SR.ReadLine());
        int[] input;

        for (int i = 0; i < people; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (input[0] == 1)
            {
                SwitchMale(input[1]);
            }
            else
            {
                SwitchFemale(input[1]);
            }
        }
    }

    static void SwitchMale(int order)
    {
        for (int i = order - 1; i < size; i += order)
        {
            arr[i] = arr[i] == 0 ? 1 : 0;
        }
    }

    static void SwitchFemale(int order)
    {
        int move = 1;

        order--;
        arr[order] = arr[order] == 0 ? 1 : 0;
        while (order - move >= 0 && order + move < size && arr[order - move] == arr[order + move])
        {
            arr[order - move] = arr[order - move] == 0 ? 1 : 0;
            arr[order + move] = arr[order + move] == 0 ? 1 : 0;
            move++;
        }
    }

    static void PrintResult()
    {
        for (int i = 0; i < size; ++i)
        {
            SW.Write($"{arr[i]} ");
            if (i % PRINT_SIZE == PRINT_SIZE - 1)
            {
                SW.WriteLine();
            }
        }
    }
}