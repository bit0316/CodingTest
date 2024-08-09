public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int right = 0;
    static int up = 0;
    static int diagonal = 0;
    static char[] movement;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());
        movement = SR.ReadLine().ToArray();

        GetRange();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void GetRange()
    {
        for (int i = 0; i < size; i++)
        {
            if (movement[i] == 'R')
            {
                right++;
            }
            else if (movement[i] == 'U')
            {
                up++;
            }
            else
            {
                diagonal++;
            }
        }
    }

    static int GetResult()
    {
        int count = 0;
        int point;
        int posX, posY;
        int min;
        int[] input;

        point = int.Parse(SR.ReadLine());
        for (int i = 0; i < point; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            posX = input[0] - 1;
            posY = input[1] - 1;

            min = Math.Min(diagonal, Math.Min(posX, posY));
            posX -= min;
            posY -= min;

            if (posX <= right && posY <= up)
            {
                count++;
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}