public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] arr;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());

        SetArray();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        string[] input = SR.ReadLine().Split();

        arr = new int[size];
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }
    }

    static int GetResult()
    {
        int max = 1;
        int up = 1;
        int down = 1;

        for (int i = 1; i < size; ++i)
        {
            if (arr[i - 1] < arr[i])
            {
                up++;
                down = 1;
                if (max < up)
                {
                    max = up;
                }
            }
            else if (arr[i - 1] > arr[i])
            {
                down++;
                up = 1;
                if (max < down)
                {
                    max = down;
                }
            }
        }

        return max;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}