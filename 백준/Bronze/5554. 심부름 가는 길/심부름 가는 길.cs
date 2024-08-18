public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_SIZE = 4;

    static void Main(string[] args)
    {
        int sec;

        sec = GetSecond(MAX_SIZE);
        PrintResult(sec);

        SR.Close();
        SW.Close();
    }

    static int GetSecond(int size)
    {
        int time = 0;

        for (int i = 0; i < size; ++i)
        {
            time += int.Parse(SR.ReadLine());
        }

        return time;
    }

    static void PrintResult(int sec)
    {
        SW.WriteLine(sec / 60);
        SW.WriteLine(sec % 60);
    }
}