public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string[] input = SR.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        int[] ans = new int[N];
        int target = N;
        int min;

        while (K > 0)
        {
            min = Math.Min(target - 1, K);
            ans[N - min - 1] = target;
            target--;
            K -= min;
        }

        for (int i = N - 1; i >= 0; --i)
        {
            if (ans[i] == 0)
            {
                ans[i] = target;
                target--;
            }
        }

        SW.WriteLine(string.Join(" ", ans));

        SR.Close();
        SW.Close();
    }
}