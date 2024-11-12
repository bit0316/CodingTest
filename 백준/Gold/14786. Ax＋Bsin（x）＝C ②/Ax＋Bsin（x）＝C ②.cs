public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        double result;
        double[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), double.Parse);
        result = GetResult(input[0], input[1], input[2]);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }


    static double GetResult(double numA, double numB, double numC)
    {
        double relativeError = 1e-9;
        double left = 0;
        double right = 2 * numC;
        double midPoint = 0;

        while (Math.Abs(right - left) > relativeError)
        {
            midPoint = (left + right) / 2;
            if (numA * midPoint + numB * Math.Sin(midPoint) <= numC)
            {
                left = midPoint;
            }
            else
            {
                right = midPoint;
            }
        }

        return midPoint;
    }

    static void PrintResult(double result)
    {
        SW.WriteLine(result);
    }
}