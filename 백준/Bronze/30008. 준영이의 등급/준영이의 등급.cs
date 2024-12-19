public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int student;
        int subject;
        int percent;
        int grade;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        student = input[0];
        subject = input[1];

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        for (int i = 0; i < subject; ++i)
        {
            percent = input[i] * 100 / student;
            if (percent <= 4)
            {
                grade = 1;
            }
            else if (percent <= 11)
            {
                grade = 2;
            }
            else if (percent <= 23)
            {
                grade = 3;
            }
            else if (percent <= 40)
            {
                grade = 4;
            }
            else if (percent <= 60)
            {
                grade = 5;
            }
            else if (percent <= 77)
            {
                grade = 6;
            }
            else if (percent <= 89)
            {
                grade = 7;
            }
            else if (percent <= 96)
            {
                grade = 8;
            }
            else
            {
                grade = 9;
            }
            SW.Write($"{grade} ");
        }

        SR.Close();
        SW.Close();
    }
}