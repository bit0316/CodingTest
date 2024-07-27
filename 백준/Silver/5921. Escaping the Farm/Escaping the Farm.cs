public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int result;
    static int[] arr;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        SetArray();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        arr = new int[size];
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }
    }

    static void GetResult()
    {
        result = 0;
        for (int i = 0; i < size; ++i)
        {
            DFS(1, arr[i], i + 1);
        }
    }

    static void DFS(int count, int sum, int index)
    {
        if (index == size)
        {
            result = Math.Max(result, count);
        }

        for (int i = index; i < size; ++i)
        {
            if (IsValid(sum.ToString(), arr[i].ToString()))
            {
                DFS(count + 1, sum + arr[i], i + 1);
            }
            else
            {
                DFS(count, sum, i + 1);
            }
        }
    }

    static bool IsValid(string strA, string strB)
    {
        int length = Math.Min(strA.Length, strB.Length);
        int numA, numB;

        for (int i = 0; i < length; ++i)
        {
            numA = strA[strA.Length - i - 1] - '0';
            numB = strB[strB.Length - i - 1] - '0';
            if (numA + numB > 9)
            {
                return false;
            }
        }

        return true;
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}