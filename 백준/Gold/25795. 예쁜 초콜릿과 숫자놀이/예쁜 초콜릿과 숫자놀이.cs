public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int DIV_SIZE = 100000;

    static int size;
    static int numA;
    static int numB;
    static int numC;
    static int result;

    static void Main(string[] args)
    {
        int[] input;
        
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        numA = input[1];
        numB = input[2];
        numC = input[3];

        GetResult((numA + numB) % DIV_SIZE, size - 1, size);
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult(long total, int white, int dark)
    {
        if (white == 0 && dark == 0)
        {
            result = (int)Math.Max(result, total % DIV_SIZE);
            return;
        }

        if (white > 0 && white <= dark)
        {
            GetResult((total + numB) % DIV_SIZE, white - 1, dark);
        }

        if (dark > 0)
        {
            GetResult((total * numC) % DIV_SIZE, white, dark - 1);
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}