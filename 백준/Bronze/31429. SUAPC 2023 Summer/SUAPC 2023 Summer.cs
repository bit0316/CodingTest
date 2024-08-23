public class Program
{
    static int[] solved = { 0, 12, 11, 11, 10, 9, 9, 9, 8, 7, 6, 6 };
    static int[] time = { 0, 1600, 894, 1327, 1311, 1004, 1178, 1357, 837, 1055, 556, 773 };

    static void Main(string[] args)
    {
        int rank = int.Parse(Console.ReadLine());

        Console.WriteLine($"{solved[rank]} {time[rank]}");
    }
}