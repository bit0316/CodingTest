public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] rooms;

        size = int.Parse(SR.ReadLine());
        rooms = new int[size];

        SetRooms(rooms, size);
        PrintResult(rooms);

        SR.Close();
        SW.Close();
    }

    static void SetRooms(int[] rooms, int size)
    {
        int height;
        int number;
        int floor;
        int room;
        string[] input;

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            height = int.Parse(input[0]);
            number = int.Parse(input[2]);

            floor = number % height;
            room = number/ height + 1;
            if (floor == 0)
            {
                floor = height;
                room--;
            }

            rooms[i] = floor * 100 + room;
        }
    }

    static void PrintResult(int[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            SW.WriteLine(arr[i]);
        }

        SW.Flush();
    }
}