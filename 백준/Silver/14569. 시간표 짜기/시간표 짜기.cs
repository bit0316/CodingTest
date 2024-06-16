public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int subjects;
    static int students;
    static int[][] sbjTimes;
    static int[][] stdTimes;
    static int[] input;

    static void Main(string[] args)
    {
        SetSubjectTime();
        SetStudentTime();
        GetResult();

        SR.Close();
        SW.Close();
    }

    static void SetSubjectTime()
    {
        subjects = int.Parse(Console.ReadLine());
        sbjTimes = new int[subjects][];

        for (int i = 0; i < subjects; i++)
        {
            input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            sbjTimes[i] = input.Skip(1).ToArray();
        }
    }

    static void SetStudentTime()
    {
        students = int.Parse(Console.ReadLine());
        stdTimes = new int[students][];

        for (int i = 0; i < students; i++)
        {
            input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            stdTimes[i] = input.Skip(1).ToArray();
        }
    }

    static void GetResult()
    {
        int count;

        foreach (var times in stdTimes)
        {
            count = sbjTimes.Count(time => time.All(times.Contains));
            SW.WriteLine(count);
        }
    }
}