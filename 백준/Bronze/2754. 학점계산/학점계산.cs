public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        float score;
        string grade;

        grade = SR.ReadLine();

        if (grade[0] == 'F')
        {
            score = 0.0f;
        }
        else
        {
            score = 'E' - grade[0];
            if (grade[1] == '+')
            {
                score += 0.3f;
            }
            else if (grade[1] == '-'){
                score -= 0.3f;
            }
        }

        SW.WriteLine($"{score:0.0}");

        SR.Close();
        SW.Close();
    }
}