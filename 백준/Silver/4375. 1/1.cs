public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string input;

        while (true)
        {
            input = SR.ReadLine();
            if (input == null)
            {
                break;
            }

            SW.WriteLine(GetCount(int.Parse(input)));
        }

        SR.Close();
        SW.Close();
    }

    static int GetCount(int num)
    {
        int mod = 0;
        int count = 0;

        do
        {
            mod = (mod * 10 + 1) % num;
            count++;
        }
        while (mod != 0);

        return count;
    }
}