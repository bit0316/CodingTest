public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<int> prime = new List<int>();
    static int num;

    static void Main(string[] args)
    {
        int result;

        num = int.Parse(SR.ReadLine());

        SetArray();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        bool[] isPrime = new bool[num + 1];
        for (int i = 2; i <= num; ++i)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= num; ++i)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= num; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        for (int i = 2; i <= num; ++i)
        {
            if (isPrime[i])
            {
                prime.Add(i);
            }
        }
    }

    static int GetResult()
    {
        int sum = 0;
        int left = 0;
        int right = 0;
        int count = 0;
        int size = prime.Count;

        while (true)
        {
            if (sum < num)
            {
                if (right == size)
                {
                    break;
                }
                sum += prime[right++];
            }
            else if (sum > num)
            {
                if (left == size)
                {
                    break;
                }
                sum -= prime[left++];
            }

            if (sum == num)
            {
                sum = 0;
                left++;
                right = left;
                count++;
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}