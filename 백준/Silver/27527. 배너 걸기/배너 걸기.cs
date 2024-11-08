public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string[] input = SR.ReadLine().Split();
        int point = int.Parse(input[0]);
        int combo = int.Parse(input[1]);
        int[] arr = SetArray(point);
        bool result = GetResult(point, combo, arr);

        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[] SetArray(int size)
    {
        int [] arr = new int[size];
        string[] input = SR.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }

        return arr;
    }

    static bool GetResult(int point, int combo, int[] arr)
    {
        int bound = (int)Math.Ceiling(9 * combo / 10.0);
        int[] count = new int[1000005];

        for (int i = 0; i < combo; ++i)
        {
            count[arr[i]]++;
            if (count[arr[i]] >= bound)
            {
                return true;
            }
        }

        for (int i = combo; i < point; ++i)
        {
            count[arr[i - combo]]--;
            count[arr[i]]++;
            if (count[arr[i]] >= bound)
            {
                return true;
            }
        }

        return false;
    }

    static void PrintResult(bool valid)
    {
        SW.WriteLine(valid ? "YES" : "NO");
    }
}