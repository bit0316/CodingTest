public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int need = input[0];
        int size = input[1];
        List<int> result;

        result = GetResult(need, size);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static List<int> GetResult(int need, int size)
    {
        List<(int, int)> grades = new List<(int, int)>();
        List<int> list = new List<int>();
        int sum = 0;
        int grade;

        for (int i = 0; i < size; ++i)
        {
            grade = int.Parse(SR.ReadLine());
            if (need <= grade && grade <= 2 * need)
            {
                list.Add(i + 1);
                return list;
            }
            if (grade <= 2 * need)
            {
                grades.Add((grade, i + 1));
            }
        }

        foreach (var value in grades)
        {
            sum += value.Item1;
            list.Add(value.Item2);
            if (sum >= need)
            {
                break;
            }
        }
        return list;
    }

    static void PrintResult(List<int> list)
    {
        SW.WriteLine(list.Count);
        foreach (var index in list)
        {
            SW.WriteLine(index);
        }
    }
}