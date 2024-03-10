public class Program
{
    static void Main(string[] args)
    {
        int size = 20;
        float points = 0;
        float total = 0;
        Dictionary<string, float> grade = new Dictionary<string, float>
        {
            {"A+", 4.5f },
            {"A0", 4.0f },
            {"B+", 3.5f },
            {"B0", 3.0f },
            {"C+", 2.5f },
            {"C0", 2.0f },
            {"D+", 1.5f },
            {"D0", 1.0f },
            {"F", 0.0f }
        };
        string[] input;

        for (int i = 0; i < size; ++i)
        {
            input = Console.ReadLine().Split();

            if (input[2] != "P")
            {
                points += float.Parse(input[1]) * grade[input[2]];
                total += float.Parse(input[1]);
            }
        }

        Console.WriteLine(points / total);
    }
}