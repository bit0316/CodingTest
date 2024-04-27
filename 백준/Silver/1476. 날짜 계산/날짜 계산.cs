public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_EARTH = 15;
    static int MAX_SUN = 28;
    static int MAX_MOON = 19;

    static void Main(string[] args)
    {
        int[] input;
        int year;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        year = GetYear(input[0], input[1], input[2]);
        PrintResult(year);

        SR.Close();
        SW.Close();
    }

    static int GetYear(int earth, int sun, int moon)
    {
        int year = 1;

        while ((year - earth) % MAX_EARTH != 0 || (year - sun) % MAX_SUN != 0 || (year - moon) % MAX_MOON != 0)
        {
            year++;
        }

        return year;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}