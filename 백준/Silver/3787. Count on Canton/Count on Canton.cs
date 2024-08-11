public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int index;
        int numA, numB;
        string input;

        while (true)
        {
            input = SR.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            index = int.Parse(input);

            (numA, numB) = GetResult(index);
            PrintResult(index, numA, numB);
        }

        SR.Close();
        SW.Close();
    }

    static (int, int) GetResult(int index)
    {
        int numA, numB;
        int count = 0;
        int line = 1;

        while (count + line < index)
        {
            count += line;
            line += 1;
        }

        index -= count;
        numA = line - (index - 1);
        numB = index;

        return line % 2 == 0 ? (numB, numA) : (numA, numB);
    }

    static void PrintResult(int term, int numA, int numB)
    {
        SW.WriteLine($"TERM {term} IS {numA}/{numB}");
    }
}