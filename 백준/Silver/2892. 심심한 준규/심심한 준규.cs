public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static HashSet<int> set = new HashSet<int>();
    static int size;
    static string[] arr;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = SR.ReadLine().Split();

        GetResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int num;

        for (int i = 0; i < size; ++i)
        {
            num = Convert.ToInt32(arr[i], 16);
            if (num >= 64 && num <= 95)
            {
                SW.Write("-");
            }
            else
            {
                SW.Write(".");
            }
        }
    }
}