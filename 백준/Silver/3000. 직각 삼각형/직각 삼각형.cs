public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<int, int> countX = new Dictionary<int, int>();
    static Dictionary<int, int> countY = new Dictionary<int, int>();
    static (int, int)[] coords;
    static int size;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        SetMap();
        GetResult();

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        int[] input;

        coords = new (int, int)[size];
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            countX[input[0]] = countX.ContainsKey(input[0]) ? countX[input[0]] + 1 : 1;
            countY[input[1]] = countY.ContainsKey(input[1]) ? countY[input[1]] + 1 : 1;
            coords[i] = (input[0], input[1]);
        }
    }

    static void GetResult()
    {
        long count = 0;
        int posX, posY;

        for (int i = 0; i < size; ++i)
        {
            (posX, posY) = coords[i];
            count += (long)(countX[posX] - 1) * (countY[posY] - 1);
        }

        SW.WriteLine(count);
    }
}