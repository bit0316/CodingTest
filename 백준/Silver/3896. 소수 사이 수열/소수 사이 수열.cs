public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_PRIME = 1299709;
    static bool[] arr;

    static void Main(string[] args)
    {
        int size;
        int num;

        SetArray();
        SetPrime();

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(SR.ReadLine());
            GetResult(num);
        }

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        arr = new bool[MAX_PRIME + 1];
        for (int i = 2; i <= MAX_PRIME; ++i)
        {
            arr[i] = true;
        }
    }

    static void SetPrime()
    {
        for (int i = 2; i * i <= MAX_PRIME; ++i)
        {
            if (arr[i])
            {
                for (int j = i * i; j < MAX_PRIME; j += i)
                {
                    arr[j] = false;
                }
            }
        }
    }

    static void GetResult(int num)
    {
        if (arr[num])
        {
            SW.WriteLine(0);
            return;
        }

        int left = num;
        int right = num;
        int count = 0;

        while (!arr[left])
        {
            left--;
            count++;
        }
        while (!arr[right])
        {
            right++;
            count++;
        }

        SW.WriteLine(count);
    }
}