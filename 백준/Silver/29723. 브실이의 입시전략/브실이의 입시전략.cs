public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<string, int> dict = new Dictionary<string, int>();
    static int subjects;
    static int total;
    static int select;

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        subjects = input[0];
        total = input[1];
        select = input[2];

        SetDictionary();
        GetResult();

        SR.Close();
        SW.Close();
    }

    static void SetDictionary()
    {
        string[] input;

        for (int i = 0; i < subjects; ++i)
        {
            input = SR.ReadLine().Split();
            dict.Add(input[0], int.Parse(input[1]));
        }
    }

    static void GetResult()
    {
        int min = 0;
        int max = 0;
        int score = 0;
        string input;

        for (int i = 0; i < select; ++i)
        {
            input = SR.ReadLine();
            score += dict[input];
            dict.Remove(input);
        }

        int[] scores = dict.Values.OrderBy(x => x).ToArray();
        int size = scores.Length - 1;
        for (int i = 0; i < total - select; ++i)
        {
            min += scores[i];
            max += scores[size - i];
        }
        SW.WriteLine($"{score + min} {score + max}");
    }
}