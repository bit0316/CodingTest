public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] arr;
    static bool[,] isPalindrome;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        SetPalindrome();
        GetResult();

        SR.Close();
        SW.Close();
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
            if (arr[i] == arr[i + 1])
            {
                isPalindrome[i, i + 1] = true;
            }
        }

        for (int i = size - 2; i >= 0; --i)
        {
            for (int j = i + 2; j < size; ++j)
            {
                if (arr[i] == arr[j] && isPalindrome[i + 1, j - 1])
                {
                    isPalindrome[i, j] = true;
                }
            }
        }
    }

    static void GetResult()
    {
        int count;
        int[] input;

        count = int.Parse(SR.ReadLine());
        for (int i = 0; i < count; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            PrintResult(input[0], input[1]);
        }
    }

    static void PrintResult(int start, int end)
    {
        SW.WriteLine(isPalindrome[start - 1, end - 1] ? 1 : 0);
    }
}