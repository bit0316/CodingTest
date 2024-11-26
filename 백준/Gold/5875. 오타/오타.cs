public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int result;
        string str;

        str = SR.ReadLine();
        result = GetResult(str);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(string str)
    {
        int ans = 0;
        int count = 0;
        int size = str.Length;
        int[] arr = new int[size];

        for (int i = 0; i < size; ++i)
        {
            if (str[i] == '(')
            {
                count++;
            }
            else if (str[i] == ')')
            {
                count--;
            }

            arr[i] = count;
        }

        if (arr[size - 1] == -2)
        {
            for (int i = 0; i < size; ++i)
            {
                if (str[i] == ')')
                {
                    ans++;
                }
                if (arr[i] < 0)
                {
                    break;
                }
            }
        }
        else if (arr[size - 1] == 2)
        {
            for (int i = size - 1; i >= 0; --i)
            {
                if (arr[i] < 2)
                {
                    break;
                }
                if (str[i] == '(')
                {
                    ans++;
                }
            }
        }

        return ans;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}