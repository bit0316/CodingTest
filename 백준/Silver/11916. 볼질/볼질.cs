public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int ball;
    static int score;
    static string[] arr;
    static bool[] bases;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        bases = new bool[3];

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int type;

        arr = SR.ReadLine().Split();
        for (int i = 0; i < size; ++i)
        {
            type = int.Parse(arr[i]);
            if (type == 1)
            {
                ball++;
            }
            else if (type == 2)
            {
                HitByPitch();
            }
            else if (type == 3)
            {
                ball++;
                WildPitch();
            }

            if (ball == 4)
            {
                HitByPitch();
            }
        }
    }

    static void HitByPitch()
    {
        if (!bases[0])
        {
            bases[0] = true;
        }
        else if (!bases[1])
        {
            bases[1] = true;
        }
        else if (!bases[2])
        {
            bases[2] = true;
        }
        else
        {
            score++;
        }
        ball = 0;
    }

    static void WildPitch()
    {
        if (bases[2])
        {
            bases[2] = false;
            score++;
        }
        if (bases[1])
        {
            bases[1] = false;
            bases[2] = true;
        }
        if (bases[0])
        {
            bases[0] = false;
            bases[1] = true;
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(score);
        SW.Flush();
    }
}