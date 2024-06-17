public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int result = 0;
        string[] input;
        
        input = SR.ReadLine().Split('-');

        result += Array.ConvertAll(input[0].Split('+'), int.Parse).Sum();
        for (int i = 1; i < input.Length; ++i)
        {
            result -= Array.ConvertAll(input[i].Split('+'), int.Parse).Sum();
        }
        SW.WriteLine(result);

        SR.Close();
        SW.Close();
    }
}