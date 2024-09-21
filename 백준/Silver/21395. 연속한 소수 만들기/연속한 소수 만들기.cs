public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int PRIME_MAX = 200000;

    static List<int> prime = new List<int>();

    static void Main(string[] args)
    {
        int size;
        int result;

        SetPrime(PRIME_MAX);

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            result = GetResult();
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static void SetPrime(int max)
    {
        bool[] isComposite = new bool[max + 1];
        for (int i = 2; i * i <= max; ++i)
        {
            if (!isComposite[i])
            {
                for (int j = i * i; j <= max; j += i)
                {
                    isComposite[j] = true;
                }
            }
        }

        for (int i = 2; i <= max; ++i)
        {
            if (!isComposite[i])
            {
                prime.Add(i);
            }
        }
    }

    static int GetResult()
    {
        int size = int.Parse(SR.ReadLine());
        int[] nums = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int count = prime.Count - size;
        int result = int.MaxValue;
        int sum;

        Array.Sort(nums);
        for (int i = 0; i < count; ++i)
        {
            sum = 0;
            for (int j = 0; j < size; ++j)
            {
                sum += Math.Abs(nums[j] - prime[i + j]);
            }
            result = Math.Min(result, sum);
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}