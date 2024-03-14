public class Program
{
    static void Main(string[] args)
    {
        int size = 4;
        int posX;
        int posY;
        string[] input;
        Coord[] coords = new Coord[size];

        for (int i = 0; i < size - 1; ++i)
        {
            input = Console.ReadLine().Split();
            posX = int.Parse(input[0]);
            posY = int.Parse(input[1]);
            coords[i] = new Coord(posX, posY);
        }

        coords[size - 1] = GetLastCoord(coords);
        posX = coords[size - 1].posX;
        posY = coords[size - 1].posY;
        Console.WriteLine($"{posX} {posY}");
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
        
    static Coord GetLastCoord(Coord[] coords)
    {
        int posX;
        int posY;
        Coord lastCoord;

        posX = coords[0].posX == coords[1].posX ? coords[2].posX : coords[0].posX + coords[1].posX - coords[2].posX;
        posY = coords[0].posY == coords[1].posY ? coords[2].posY : coords[0].posY + coords[1].posY - coords[2].posY;
        lastCoord = new Coord(posX, posY);

        return lastCoord;
    }
}