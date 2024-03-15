public class Program
{
    static void Main(string[] args)
    {
        int weight;
        int count = 0;

        weight = int.Parse(Console.ReadLine());

        for (int i = 0; i < 5 && weight >= 0; ++i)
        {
            if (weight % 5 == 0)
            {
                count += i;
                count += weight / 5;
                break;
            }
            weight -= 3;
        }

        if (count == 0)
        {
            count = -1;
        }

        Console.WriteLine(count);
    }
}