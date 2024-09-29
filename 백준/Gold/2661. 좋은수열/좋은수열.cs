public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static string result;
    static bool finished;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        GetResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        finished = false;
        BackTracking("", 0);
    }

    static void BackTracking(string str, int index)
    {
        if (finished)
        {
            return;
        }

        int length = str.Length;
        for (int i = 1; i <= length / 2; ++i)
        {
            if (str.Substring(length - 2 * i, i) == str.Substring(length - i, i))
            {
                return;
            }
        }

        if (length == size)
        {
            SW.WriteLine(str);
            finished = true;
            return;
        }

        BackTracking(str + "1", index + 1);
        BackTracking(str + "2", index + 1);
        BackTracking(str + "3", index + 1);
    }
}