public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const long MAX_NUM = 9 * (long)1e18;

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        long min = MAX_NUM;
        long max = 0;
        long money = 0;
        long charge;
        long[] input;

        for (int i = 0; i < size; i++)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), long.Parse);
            if (input[0] > 0 || money + input[0] >= 0)
            {
                money += input[0];
                if (money != input[1])
                {
                    min = -1;
                    break;
                }
                continue;
            }

            charge = input[1] - (money + input[0]);
            if (min != MAX_NUM)
            {
                charge = GetGCD(min, charge);
            }

            max = Math.Max(max, input[1]);
            if (charge <= max || (charge == 1 && input[1] > 0))
            {
                min = -1;
                break;
            }

            min = Math.Min(min, charge);
            money = input[1];
        }

        SW.WriteLine(min);

        SR.Close();
        SW.Close();
    }

    static long GetGCD(long numA, long numB)
    {
        while (numB > 0)
        {
            (numA, numB) = (numB, numA % numB);
        }
        return numA;
    }
}