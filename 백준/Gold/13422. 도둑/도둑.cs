public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; i++)
        {
            result = GetResult();
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult()
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int house = input[0];
        int thief = input[1];
        int cost = input[2];

        int[] houses = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        if (house - thief != 0)
        {
            houses = houses.Concat(houses.Take(thief - 1)).ToArray();
        }

        int count = houses.Length;
        int money = houses.Take(thief).Sum();
        int start = 0;
        int end = thief - 1;
        int result = 0;

        while (true)
        {
            if (money < cost)
            {
                result++;
            }
            money -= houses[start];
            start++;
            end++;

            if (end == count)
            {
                break;
            }
            money += houses[end];
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}