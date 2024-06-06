public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] maxArr;
    static int[] minArr;
    static int[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        maxArr = new int[size];
        minArr = new int[size];

        GetResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int[] tempArr = new int[size];
        
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        maxArr = (int[])input.Clone();
        minArr = (int[])input.Clone();
        for (int i = 1; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

            tempArr = (int[])maxArr.Clone();
            maxArr[0] = Math.Max(tempArr[0], tempArr[1]) + input[0];
            maxArr[1] = Math.Max(Math.Max(tempArr[0], tempArr[1]), tempArr[2]) + input[1];
            maxArr[2] = Math.Max(tempArr[1], tempArr[2]) + input[2];

            tempArr = (int[])minArr.Clone();
            minArr[0] = Math.Min(tempArr[0], tempArr[1]) + input[0];
            minArr[1] = Math.Min(Math.Min(tempArr[0], tempArr[1]), tempArr[2]) + input[1];
            minArr[2] = Math.Min(tempArr[1], tempArr[2]) + input[2];
        }

        SW.WriteLine($"{maxArr.Max()} {minArr.Min()}");
    }
}