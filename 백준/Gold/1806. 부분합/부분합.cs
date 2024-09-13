public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int result;
        int size;
        int num;
        int[] arr;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        num = input[1];
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetResult(size, num, arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int size, int num, int[] arr)
    {
        int length = int.MaxValue;
        int left = 0;
        int right = 0;
        int sum = 0;

        while (true)
        {
            if (sum < num)
            {
                if (right == size)
                {
                    break;
                }
                sum += arr[right++];
            }
            else 
            {
                if (left == size)
                {
                    break;
                }
                length = Math.Min(length, right - left);
                sum -= arr[left++];
            }
        }

        return length == int.MaxValue ? 0 : length;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}