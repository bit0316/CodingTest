public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int input;
        int remain;
        string result;

        input = int.Parse(SR.ReadLine());

        if (input == 0)
        {
            SW.WriteLine(0);
        }
        else
        {
            result = "";
            while (input != 0)
            {
                remain = Math.Abs(input % -2);
                result += remain;
                input = (int)Math.Ceiling((double)input / -2);
            }
            SW.WriteLine(result.Reverse().ToArray());
        }

        SR.Close();
        SW.Close();
    }
}