public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static HashSet<string> set = new HashSet<string>();
    static string[] input;

    static void Main(string[] args)
    {
        while (true)
        {
            input = SR.ReadLine().Split();
            if (input[0] == "##")
            {
                break;
            }

            set.Add(input[0]);
        }

        while (true)
        {
            input = SR.ReadLine().Split();
            if (input[0] == "#")
            {
                break;
            }
            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i].Length < 4 || !set.Contains($"{input[i][0]}{input[i][3]}"))
                {
                    SW.Write($"{input[i]} ");
                    continue;
                }

                SW.Write($"{input[i][0]}**{input[i][3]}");
                for (int j = 4; j < input[i].Length; ++j)
                {
                    SW.Write(input[i][j]);
                }
                SW.Write(" ");
            }
        }

        SR.Close();
        SW.Close();
    }
}