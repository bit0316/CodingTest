public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int count;
    static int[] arr;
    static int[] nums;
    static string[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        arr = new int[size + 1];
        for (int i = 1; i <= size; ++i)
        {
            SetArray();
            GetResult(i);
            PrintResult(i);
        }

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        count = int.Parse(SR.ReadLine());
        input = SR.ReadLine().Split();

        nums = new int[count];
        for (int i = 0; i < count; ++i)
        {
            nums[i] = int.Parse(input[i]);
        }
        Array.Sort(nums);
    }

    static void GetResult(int index)
    {
        int order = 1;

        foreach (int num in nums)
        {
            if (num >= order)
            {
                arr[index]++;
                order++;
            }
        }
    }

    static void PrintResult(int index)
    {
        SW.WriteLine($"Case #{index}: {arr[index]}");
    }
}