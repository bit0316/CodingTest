public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int shirtBundle;
    static int penBundle;
    static int[] shirts;
    static int[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        shirts = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        shirtBundle = input[0];
        penBundle = input[1];

        GetShirtResult();
        GetPenResult();

        SR.Close();
        SW.Close();
    }

    static void GetShirtResult()
    {
        int count = 0;

        foreach (var shirt in shirts)
        {
            count += shirt / shirtBundle;
            if (shirt % shirtBundle != 0)
            {
                count++;
            }
        }

        SW.WriteLine(count);
    }

    static void GetPenResult()
    {
        SW.WriteLine($"{size / penBundle} {size % penBundle}");
    }
}