public class Program
{
    static void Main(string[] args)
    {
        int size;
        int posX;
        int posY;
        string[] input;
        Coord[] coords;

        size = int.Parse(Console.ReadLine());
        coords = new Coord[size];

        for (int i = 0; i < size; ++i)
        {
            input = Console.ReadLine().Split();
            posX = int.Parse(input[0]);
            posY = int.Parse(input[1]);
            coords[i] = new Coord(posX, posY);
        }

        Console.WriteLine(GetArea(coords));
    }

    public class Coord
    {
        public int posX;
        public int posY;

        public Coord(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }

    static int GetArea(Coord[] coords)
    {
        int minX = coords[0].posX;
        int minY = coords[0].posY;
        int maxX = coords[0].posX;
        int maxY = coords[0].posY;
        int result;

        for (int i = 1; i < coords.Length; ++i)
        {
            if (minX > coords[i].posX)
            {
                minX = coords[i].posX;
            }
            if (minY > coords[i].posY)
            {
                minY = coords[i].posY;
            }
            if (maxX < coords[i].posX)
            {
                maxX = coords[i].posX;
            }
            if (maxY < coords[i].posY)
            {
                maxY = coords[i].posY;
            }
        }

        result = (maxX - minX) * (maxY - minY);
        return result;
    }
}