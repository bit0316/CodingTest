public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<List<int>> groups;
    static Queue<int> truth;
    static int people;
    static int party;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        people = input[0];
        party = input[1];

        SetTruth();
        SetGroup();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetTruth()
    {
        truth = new Queue<int>();

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        for (int i = 1; i <= input[0]; ++i)
        {
            truth.Enqueue(input[i]);
        }
    }

    static void SetGroup()
    {
        groups = new List<List<int>>();

        for (int i = 0; i < party; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

            groups.Add(new List<int>());
            for (int j = 1; j <= input[0]; ++j)
            {
                groups[i].Add(input[j]);
            }
        }
    }

    static int GetResult()
    {
        int index;

        while (truth.Count > 0)
        {
            index = truth.Dequeue();

            for (int i = 0; i < groups.Count; ++i)
            {
                if (groups[i].Contains(index))
                {
                    foreach (int person in groups[i])
                    {
                        truth.Enqueue(person);
                    }
                    groups.Remove(groups[i]);
                }
            }
        }

        return groups.Count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}