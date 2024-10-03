public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int sumA = Array.ConvertAll(SR.ReadLine().Split(), int.Parse).Sum(); 
        int sumB = Array.ConvertAll(SR.ReadLine().Split(), int.Parse).Sum(); 
        int max = Math.Max(sumA, sumB);

        SW.WriteLine(max);

        SR.Close();
        SW.Close();
    }
}