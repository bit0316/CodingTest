public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static string[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            if (input.Distinct().Count() < 3)
            {
                SW.WriteLine(":)");
                continue;
            }

            input = input.OrderBy(x => x).ToArray();
            if ((input.Contains($"{int.Parse(input[0][0].ToString()) + 1}{input[0][1]}") &&
                input.Contains($"{int.Parse(input[0][0].ToString()) + 2}{input[0][1]}")) ||
                (input.Contains($"{int.Parse(input[1][0].ToString()) + 1}{input[1][1]}") &&
                input.Contains($"{int.Parse(input[1][0].ToString()) + 2}{input[1][1]}")))
            {
                SW.WriteLine(":)");
                continue;
            }

            SW.WriteLine(":(");
        }

        SR.Close();
        SW.Close();
    }
}