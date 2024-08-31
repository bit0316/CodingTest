public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int[] pos;
        int result;

        pos = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        result = GetResult(pos[0], pos[1]);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int posX, int posY)
    {
        if (posX == 0 && posY == 0)
        {
            return 1;
        }

        int max = Math.Max(posX, posY);
        int distance = 1;

        while (distance * 3 <= max)
        {
            distance *= 3;
        }

        for (int i = distance; i > 0; i /= 3)
        {
            if (posX > posY)
            {
                posX -= i;
            }
            else
            {
                posY -= i;
            }
        }

        return posX == 0 && posY == 0 ? 1 : 0;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}