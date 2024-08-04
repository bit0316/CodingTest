public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int BLIND_SIZE = 5;

    static int row;
    static int col;
    static int[] arr;

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];

        SetArray();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        string input;

        arr = new int[BLIND_SIZE];
        arr[0] = row * col;

        for (int i = 0; i < BLIND_SIZE * row + 1; ++i)
        {
            input = SR.ReadLine();
            if (i % BLIND_SIZE == 0)
            {
                continue;
            }

            for (int j = 1; j < BLIND_SIZE * col; j += BLIND_SIZE)
            {
                if (input[j] == '*')
                {
                    arr[i % BLIND_SIZE - 1]--;
                    arr[i % BLIND_SIZE]++;
                }
            }
        }
    }

    static void PrintResult()
    {
        for (int i = 0; i < BLIND_SIZE; ++i)
        {
            SW.Write($"{arr[i]} ");
        }
    }
}