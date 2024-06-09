public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int day;
    static int result;
    static int[] prices;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            day = int.Parse(SR.ReadLine());

            result = 0;
            for (int j = 0; j < day; ++j)
            {
                prices = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
                if (prices.Max() > 0)
                {
                    result += prices.Max();
                }
            }
            SW.WriteLine(result);
        }

        SR.Close();
        SW.Close();
    }
}