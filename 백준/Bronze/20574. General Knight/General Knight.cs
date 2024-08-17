public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTION = { (-1, -1), (-1, 1), (1, -1), (1, 1) };
    static int ROW = 8;
    static int COL = 8;

    static void Main(string[] args)
    {
        int[] distance = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        string position = SR.ReadLine();
        SortedSet<string> result;

        result = GetResult(position[0] - 'a', int.Parse(position[1].ToString()), distance);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static SortedSet<string> GetResult(int posX, int posY, int[] distance)
    {
        SortedSet<string> nextPos = new SortedSet<string>();
        int curX, curY;

        foreach (var dir in DIRECTION)
        {
            curX = posX + dir.Item1 * distance[0];
            curY = posY + dir.Item2 * distance[1];
            if (curX >= 0 && curY > 0 && curX < ROW && curY <= COL)
            {
                nextPos.Add($"{(char)(curX + 'a')}{curY} ");
            }

            curX = posX + dir.Item1 * distance[1];
            curY = posY + dir.Item2 * distance[0];
            if (curX >= 0 && curY > 0 && curX < ROW && curY <= COL)
            {
                nextPos.Add($"{(char)(curX + 'a')}{curY} ");
            }
        }

        return nextPos;
    }

    static void PrintResult(SortedSet<string> result)
    {
        int size = result.Count;

        SW.WriteLine(size);
        foreach (string pos in result)
        {
            SW.Write(pos);
        }
    }
}