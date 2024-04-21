public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int resultA;
        int resultB;
        int temp;
        int num;
        
        num = int.Parse(SR.ReadLine());
        resultA = 1;
        resultB = num - 2;
        temp = resultA;

        for (int i = 0; i < num - 2; ++i)
        {
            (temp, resultA) = (resultA, resultA + temp);
        }

        SW.WriteLine($"{resultA} {resultB}");

        SR.Close();
        SW.Close();
    }
}