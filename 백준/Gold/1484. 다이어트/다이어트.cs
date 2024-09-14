public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int weight;

        weight = int.Parse(SR.ReadLine());
        GetResult(weight);

        SR.Close();
        SW.Close();
    }

    static void GetResult(int weight)
    {
        long left = 1;
        long right = 1;
        long result;
        bool isValid = false;

        while (true)
        {
            result = right * right - left * left;
            if (result == weight)
            {
                isValid = true;
                PrintResult(right);
            }
            else if (right - left == 1 && result > weight)
            {
                break;
            }

            if (result > weight)
            {
                left++;
            }
            else
            {
                right++;
            }
        }

        if (!isValid)
        {
            PrintResult(-1);
        }
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}