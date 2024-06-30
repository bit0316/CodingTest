public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int size = arr[0];
        int numA = arr[1];
        int numB = arr[2];
        int numC = arr[3];

        SW.WriteLine(Fact(size) / (Fact(numA) * Fact(numB) * Fact(numC)));

        SR.Close();
        SW.Close();
    }

    static long Fact(int num)
    {
        long result = 1;

        while (num > 1)
        {
            result *= num;
            num--;
        }

        return result;
    }
}