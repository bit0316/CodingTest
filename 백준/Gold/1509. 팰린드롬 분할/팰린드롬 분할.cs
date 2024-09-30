public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int MAX_VALUE = 2500;

    static string str;
    static int size;
    static int[] arr;
    static bool[,] isPalindrome;

    static void Main(string[] args)
    {
        int result;

        str = SR.ReadLine();
        size = str.Length;

        InitArray();
        SetPalindrome();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void InitArray()
    {
        arr = new int[size + 1];
        for (int i = 0; i < size; ++i)
        {
            arr[i] = MAX_VALUE;
        }
    }

    static void SetPalindrome()
    {
        isPalindrome = new bool[size, size];
        for (int i = 0; i < size; ++i)
        {
            isPalindrome[i, i] = true;
        }

        for (int i = 0; i < size - 1; ++i)
        {
            if (str[i] == str[i + 1])
            {
                isPalindrome[i, i + 1] = true;
            }
        }

        for (int i = size - 2; i >= 0; --i)
        {
            for (int j = i + 2; j < size; ++j)
            {
                if (str[i] == str[j] && isPalindrome[i + 1, j - 1])
                {
                    isPalindrome[i, j] = true;
                }
            }
        }
    }

    static int GetResult()
    {
        for (int i = 0; i < size; ++i)
        {
            if (isPalindrome[0, i])
            {
                arr[i] = Math.Min(arr[i], 1);
            }
            for (int j = 1; j <= i; ++j)
            {
                if (isPalindrome[j, i])
                {
                    arr[i] = Math.Min(arr[i], arr[j - 1] + 1);
                }
            }
        }

        return arr[size - 1];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}