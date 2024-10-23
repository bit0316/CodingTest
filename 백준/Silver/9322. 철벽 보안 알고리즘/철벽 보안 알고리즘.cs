public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int count;
        string[] arrA;
        string[] arrB;
        string[] arrC;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            count = int.Parse(SR.ReadLine());
            arrA = SR.ReadLine().Split();
            arrB = SR.ReadLine().Split();
            arrC = SR.ReadLine().Split();
            GetResult(count, arrA, arrB, arrC);
        }


        SR.Close();
        SW.Close();
    }

    static void GetResult(int count, string[] arrA, string[] arrB, string[] arrC)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < count; ++i)
        {
            dict[i] = Array.IndexOf(arrB, arrA[i]);
        }

        SW.Write(arrC[dict[0]]);
        for (int i = 1; i < count; ++i)
        {
            SW.Write($" {arrC[dict[i]]}");
        }
        SW.WriteLine();
    }
}