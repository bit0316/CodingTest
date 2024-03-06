public class Program
{
    static void Main(string[] args)
    {
        int coordinateX;
        int coordinateY;

        coordinateX = int.Parse(Console.ReadLine());
        coordinateY = int.Parse(Console.ReadLine());

        if (coordinateX > 0)
        {
            if (coordinateY > 0)
            {
                Console.WriteLine("1");
            }
            else if (coordinateY < 0)
            {
                Console.WriteLine("4");
            }
        }
        else if (coordinateX < 0)
        {
            if (coordinateY > 0)
            {
                Console.WriteLine("2");
            }
            else if (coordinateY < 0)
            {
                Console.WriteLine("3");
            }
        }
    }
}