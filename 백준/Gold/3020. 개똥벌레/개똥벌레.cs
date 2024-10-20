public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int[] arrA;
    static int[] arrB;
    static int length;
    static int height;

    static void Main(string[] args)
    {
        int destroy;
        int path;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        length = input[0];
        height = input[1];

        SetArray();
        (destroy, path) = GetReult();
        PrintResult(destroy, path);
        
        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        int meter;

        arrA = new int[height + 1];
        arrB = new int[height + 1];

        for (int i = 0; i < length; i++)
        {
            meter = int.Parse(SR.ReadLine());
            if (i % 2 == 0)
            {
                arrA[meter]++;
            }
            else
            {
                arrB[meter]++;
            }
        }

        for (int i = height - 1; i > 0; --i)
        {
            arrA[i] += arrA[i + 1];
            arrB[i] += arrB[i + 1];
        }
    }

    static (int, int) GetReult()
    {
        int min = int.MaxValue;
        int path = 0;
        int count;

        for (int i = 1; i <= height; ++i)
        {
            count = arrA[i] + arrB[height - i + 1];
            if (min > count)
            {
                min = count;
                path = 1;
            }
            else if (min == count)
            {
                path++;
            }
        }

        return (min, path);
    }

    static void PrintResult(int destroy, int path)
    {
        SW.WriteLine($"{destroy} {path}");
    }
}