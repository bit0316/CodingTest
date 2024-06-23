public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int degree;
        int remain;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            degree = int.Parse(SR.ReadLine());
            remain = degree % 10;
            degree -= remain < 5 ? remain : remain - 10;
            degree = degree % 180 / 10;

            if (degree == 0)
            {
                degree += 18;
            }

            if (degree < 10)
            {
                SW.Write("0");
            }
            SW.WriteLine(degree);
        }

        SR.Close();
        SW.Close();
    }
}