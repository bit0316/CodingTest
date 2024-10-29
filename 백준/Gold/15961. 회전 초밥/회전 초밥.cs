public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string[] input = SR.ReadLine().Split();
        int numN = int.Parse(input[0]);
        int numD = int.Parse(input[1]);
        int numK = int.Parse(input[2]);
        int numC = int.Parse(input[3]);
        int result;
        int[] arr;

        arr = SetArray(numN, numK);
        result = GetResult(numN, numC, numK, arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[] SetArray(int numN, int numK)
    {
        int[] arr = new int[numN + numK];
        for (int i = 0; i < numN; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }

        for (int i = 0; i < numK; ++i)
        {
            arr[i + numN] = arr[i];
        }

        return arr;
    }

    static int GetResult(int numN, int numC, int numK, int[] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int max = 0;
        int count;

        for (int i = 0; i < numK; ++i)
        {
            dict[arr[i]] = dict.ContainsKey(arr[i]) ? dict[arr[i]] + 1 : 1;
        }

        for (int i = numK; i < numN + numK; ++i)
        {
            count = dict.ContainsKey(numC) ? dict.Count - 1 : dict.Count;
            max = Math.Max(max, count);

            if (dict[arr[i - numK]] == 1)
            {
                dict.Remove(arr[i - numK]);
            }
            else
            {
                dict[arr[i - numK]]--;
            }

            dict[arr[i]] = dict.ContainsKey(arr[i]) ? dict[arr[i]] + 1 : 1;
        }

        return max + 1;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}