public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());


    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        SW.WriteLine((input[0] * input[1] / 2f).ToString("F1"));

        SR.Close();
        SW.Close();
    }
}