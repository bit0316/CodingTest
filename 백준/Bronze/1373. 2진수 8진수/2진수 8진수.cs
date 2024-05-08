public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string input = SR.ReadLine();

        int remain = input.Length % 3;
        if (remain != 0)
        {
            for (int i = 0; i < 3 - remain; ++i)
            {
                input = '0' + input;
            }
        }

        int sum;
        for (int i = 0; i < input.Length; i += 3)
        {
            sum = int.Parse(input[i].ToString()) * 4
                + int.Parse(input[i + 1].ToString()) * 2
                + int.Parse(input[i + 2].ToString());
            SW.Write(sum);
        }

        SR.Close();
        SW.Close();
    }
}