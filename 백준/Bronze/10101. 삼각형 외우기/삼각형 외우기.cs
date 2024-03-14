public class Program
{
    static void Main(string[] args)
    {
        int size = 3;
        int[] angles = new int[size];

        for (int i = 0; i < size; ++i)
        {
            angles[i] = int.Parse(Console.ReadLine());
        }

        PrintTriangleType(angles);
    }

    static void PrintTriangleType(int[] angles)
    {
        int totalAngles = 0;
        int count = 0;

        totalAngles += angles[0] + angles[1] + angles[2];
        if (angles[0] == angles[1])
        {
            count++;
        }
        if (angles[1] == angles[2])
        {
            count++;
        }
        if (angles[2] == angles[0])
        {
            count++;
        }

        if (totalAngles == 180)
        {
            if (count == 3)
            {
                Console.WriteLine("Equilateral");
            }
            else if (count == 1)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}