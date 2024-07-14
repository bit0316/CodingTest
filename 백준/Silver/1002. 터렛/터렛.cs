public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    struct Coord
    {
        public int posX;
        public int posY;
        public int radious;

        public Coord(int x, int y, int r)
        {
            posX = x;
            posY = y;
            radious = r;
        }
    }

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            result = GetResult();
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult()
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        Coord coordA = new Coord(input[0], input[1], input[2]);
        Coord coordB = new Coord(input[3], input[4], input[5]);

        if (coordA.posX == coordB.posX && coordA.posY == coordB.posY && coordA.radious == coordB.radious)
        {
            return -1;
        }

        double adjacent = Math.Pow(coordA.posX - coordB.posX, 2);
        double opposite = Math.Pow(coordA.posY - coordB.posY, 2);
        double hypotenuse = adjacent + opposite;
        double limitMin = Math.Pow(coordA.radious - coordB.radious, 2);
        double limitMax = Math.Pow(coordA.radious + coordB.radious, 2);

        return (hypotenuse < limitMin || hypotenuse > limitMax) ? 0 : (hypotenuse == limitMin || hypotenuse == limitMax) ? 1 : 2;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}