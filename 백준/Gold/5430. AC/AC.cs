public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int count;
    static int start;
    static int end;
    static int[] arr;
    static bool isReverse;
    static bool isError;

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            GetResult();
            PrintArray();
        }

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        string func;
        string input;

        func = SR.ReadLine();
        count = int.Parse(SR.ReadLine());
        input = SR.ReadLine();
        input = input.Substring(1, input.Length - 2);

        start = 1;
        end = 0;
        if (count > 0)
        {
            arr = Array.ConvertAll(input.Split(','), int.Parse);
            start = 0;
            end = arr.Length - 1;
        }

        isError = false;
        isReverse = false;
        for (int i = 0; i < func.Length; ++i)
        {
            if (func[i] == 'R')
            {
                isReverse = !isReverse;
            }
            else if (func[i] == 'D')
            {
                if (start == end + 1)
                {
                    isError = true;
                    return;
                }
                else if (!isReverse)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
        }
    }

    static void PrintArray()
    {
        if (isError)
        {
            SW.WriteLine("error");
            return;
        }
        else if (start == end + 1)
        {
            SW.WriteLine("[]");
            return;
        }

        SW.Write($"[");
        if (!isReverse)
        {
            SW.Write($"{arr[start]}");
            for (int i = start + 1; i <= end; ++i)
            {
                SW.Write($",{arr[i]}");
            }
        }
        else
        {
            SW.Write($"{arr[end]}");
            for (int i = end - 1; i >= start; --i)
            {
                SW.Write($",{arr[i]}");
            }
        }
        SW.WriteLine("]");
    }
}