public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string input;
        int count;
        int size;

        while (true)
        {
            input = SR.ReadLine().ToUpper();
            if (input == "#")
            {
                break;
            }

            count = 0;
            size = input.Length;
            for (int i = 0; i < size; ++i)
            {
                if (input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    count++;
                }
            }

            SW.WriteLine(count);
        }

        SR.Close();
        SW.Close();
    }
}