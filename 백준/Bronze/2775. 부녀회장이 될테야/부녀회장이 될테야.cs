public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] arr;

        size = int.Parse(SR.ReadLine());
        arr = new int[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = GetResidents();
        }
        PrintArray(arr, size);

        SR.Close();
        SW.Close();
    }

    static int GetResidents()
    {
        int floor = int.Parse(SR.ReadLine());
        int room = int.Parse(SR.ReadLine());
        int[] residents = new int[room];
        int count = 0;

        for (int i = 0; i < room; ++i)
        {
            residents[i] = i + 1;
        }

        for (int i = 0; i < floor; ++i)
        {
            count = 0;
            for (int j = 0; j < room; ++j)
            {
                count += residents[j];
                residents[j] = count;
            }
        }

        return count;
    }

    static void PrintArray(int[] arr, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            SW.WriteLine(arr[i]);
        }
    }
}