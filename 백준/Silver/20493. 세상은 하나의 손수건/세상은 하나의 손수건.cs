public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int totalTime;
    static int posX;
    static int posY;
    static string[] input;

    static void Main(string[] args)
    {
        input = SR.ReadLine().Split();
        size = int.Parse(input[0]);
        totalTime = int.Parse(input[1]);

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int curTime = 0;
        int distance;
        int dir = 0;

        for (int i = 0; i < size; ++i)
        {

            input = SR.ReadLine().Split();
            distance = int.Parse(input[0]) - curTime;
            curTime = int.Parse(input[0]);

            CalculatePosition(dir, distance);
            if (input[1] == "left")
            {
                dir = dir == 0 ? 3 : dir - 1;
            }
            else if (input[1] == "right")
            {
                dir = dir == 3 ? 0 : dir + 1;
            }
        }

        CalculatePosition(dir, totalTime - curTime);
    }

    static void CalculatePosition(int dir, int distance)
    {
        if (dir % 2 == 0)
        {
            posX += dir < 2 ? distance : -distance;
        }
        else
        {
            posY += dir < 2 ? -distance : distance;
        }
    }

    static void PrintResult()
    {
        SW.WriteLine($"{posX} {posY}");
    }
}