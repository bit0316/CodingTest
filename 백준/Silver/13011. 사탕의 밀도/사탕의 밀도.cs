public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_GRAM = 1000000;
    static double DIFF = 1e-9 / 2;

    static int size;
    static double sum;
    static double[] liter;
    static double[] gram;

    static void Main(string[] args)
    {
        double result;

        size = int.Parse(SR.ReadLine());
        liter = Array.ConvertAll(SR.ReadLine().Split(), double.Parse);
        gram = Array.ConvertAll(SR.ReadLine().Split(), double.Parse);

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static double GetResult()
    {
        double left = 0;
        double right = MAX_GRAM;
        double densityA = (2 * left + right) / 3;
        double densityB = (left + 2 * right) / 3;
        double midA = GetSum(densityA);
        double midB = GetSum(densityB);

        while (Math.Abs(midA - midB) > DIFF)
        {
            densityA = (2 * left + right) / 3;
            densityB = (left + 2 * right) / 3;
            midA = GetSum(densityA);
            midB = GetSum(densityB);

            if (midA > midB)
            {
                left = densityA;
            }
            else
            {
                right = densityB;
            }
        }

        return midA;
    }

    static double GetSum(double density)
    {
        sum = 0;
        for (int i = 0; i < size; ++i)
        {
            sum += Math.Abs(liter[i] * density - gram[i]);
        }

        return sum;
    }

    static void PrintResult(double result)
    {
        SW.WriteLine(result);
    }
}