public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int length;
        int[] arr;
        bool result;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            length = int.Parse(SR.ReadLine());
            arr = SetArray(length);
            result = GetResult(arr);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int[] SetArray(int size)
    {
        int[] arr = new int[size];
        string[] input;
        
        input = SR.ReadLine().Split();
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }

        return arr;
    }

    static bool GetResult(int[] arr)
    {
        int length = arr.Length;
        int index = 0;
        int count = 0;
        int[] check;

        check = new int[length + 1];
        for (int i = 0; i < length; ++i)
        {
            if (arr[i] == index + 1)
            {
                index++;
                while (index + 1 < check.Length && check[index + 1] != 0)
                {
                    if (check[index + 1] == 2)
                    {
                        count--;
                    }
                    index++;
                }
            }
            else
            {
                if (check[arr[i] - 1] == 0)
                {
                    count++;
                    check[arr[i]] = 2;
                }
                else
                {
                    check[arr[i]] = 1;
                }
            }

            if (count > 2)
            {
                return false;
            }
        }
        return true;
    }

    static void PrintResult(bool valid)
    {
        SW.WriteLine(valid ? "YES" : "NO");
    }
}