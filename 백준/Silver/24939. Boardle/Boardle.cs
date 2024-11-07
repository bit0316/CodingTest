public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int row;
    static int col;
    static long minX;
    static long minY;
    static long maxX;
    static long maxY;

    static void Main(string[] args)
    {
        int count;
        string[] input;

        input = SR.ReadLine().Split();
        row = int.Parse(input[0]);
        col = int.Parse(input[1]);

        InitCoord();
        count = int.Parse(SR.ReadLine());
        for (int i = 0; i < count; ++i)
        {
            input = SR.ReadLine().Split();
            GetResult(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]));
        }
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void InitCoord()
    {
        minX = 1;
        minY = 1;
        maxX = row;
        maxY = col;
    }

    static void GetResult(int posX, int posY, int dir)
    {
        switch (dir)
        {
            case 1:
                minY = maxY = posY;
                minX = Math.Max(minX, posX + 1);
                break;
            case 2:
                minY = maxY = posY;
                maxX = Math.Min(maxX, posX - 1);
                break;
            case 3:
                minX = maxX = posX;
                maxY = Math.Min(maxY, posY - 1);
                break;
            case 4:
                minX = maxX = posX;
                minY = Math.Max(minY, posY + 1);
                break;
            case 5:
                minX = Math.Max(minX, posX + 1);
                minY = Math.Max(minY, posY + 1);
                break;
            case 6:
                maxX = Math.Min(maxX, posX - 1);
                minY = Math.Max(minY, posY + 1);
                break;
            case 7:
                minX = Math.Max(minX, posX + 1);
                maxY = Math.Min(maxY, posY - 1);
                break;
            case 8:
                maxX = Math.Min(maxX, posX - 1);
                maxY = Math.Min(maxY, posY - 1);
                break;
            case 9:
                minX = maxX = posX;
                minY = maxY = posY;
                break;
        }
    }

    static void PrintResult()
    {
        SW.WriteLine((maxX - minX + 1) * (maxY - minY + 1));
    }
}