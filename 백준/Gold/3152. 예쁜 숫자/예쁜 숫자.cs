public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int numP;
        bool result;
        string[] input;

        input = SR.ReadLine().Split();
        numP = int.Parse(input[0]);

        for (int i = 1; i <= 4; ++i)
        {
            result = GetResult(numP, long.Parse(input[i]));
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static bool GetResult(int numP, long numN)
    {
        long numQ;
        int c0 = 0;
        int c1 = 0;
        int c2 = 0;
        int numR;

        while (numN > 0)
        {
            numQ = numN / numP;
            numR = (int)(numN % numP);

            if (numR > 2)
            {
                return false;
            }

            if (numR == 0)
            {
                c0++;
            }
            else if (numR == 1)
            {
                c1++;
            }
            else if (numR == 2)
            {
                c2++;
            }

            numN = numQ;
        }

        return !((c1 != 1 || c2 == 0) && (c1 != 2 || c2 != 0));
    }

    static void PrintResult(bool result)
    {
        SW.Write(result ? "1 " : "0 ");
    }
}