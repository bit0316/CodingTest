public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static long[] arr;
    static long[] pick;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), long.Parse);
        Array.Sort(arr);

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        long min = long.MaxValue;
        long sum;
        int left, right;

        pick = new long[3];
        for (int i = 0; i < size - 2; ++i)
        {
            left = i + 1;
            right = size - 1;
            while (left < right)
            {
                sum = arr[i] + arr[left] + arr[right];
                if (min > Math.Abs(sum))
                {
                    min = Math.Abs(sum);
                    pick[0] = arr[i];
                    pick[1] = arr[left];
                    pick[2] = arr[right];
                }

                if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
    }

    static void PrintResult()
    {
        SW.WriteLine($"{pick[0]} {pick[1]} {pick[2]}");
    }
}