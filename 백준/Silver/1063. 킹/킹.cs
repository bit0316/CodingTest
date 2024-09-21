public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<string, (int, int)> DIRECTIONS = new Dictionary<string, (int, int)>
    {
        { "R", (1, 0) }, { "L", (-1, 0) }, { "B", (0, -1) }, { "T", (0, 1) },
        { "RT", (1, 1) }, { "LT", (-1, 1) }, { "RB", (1, -1) }, { "LB", (-1, -1) },
    };

    static (int, int) king;
    static (int, int) stone;
    static int size;

    static void Main(string[] args)
    {
        string[] input = SR.ReadLine().Split();

        king = (input[0][0] - 'A' + 1, input[0][1] - '0');
        stone = (input[1][0] - 'A' + 1, input[1][1] - '0');
        size = int.Parse(input[2]);

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        string input;
        int kingX, kingY;
        int stoneX, stoneY;

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine();
            kingX = king.Item1 + DIRECTIONS[input].Item1;
            kingY = king.Item2 + DIRECTIONS[input].Item2;
            if (kingX == 0 || kingY == 0 || kingX == 9 || kingY == 9)
            {
                continue;
            }

            if (kingX != stone.Item1 || kingY != stone.Item2)
            {
                king = (kingX, kingY);
                continue;
            }

            stoneX = stone.Item1 + DIRECTIONS[input].Item1;
            stoneY = stone.Item2 + DIRECTIONS[input].Item2;
            if (stoneX > 0 && stoneY > 0 && stoneX < 9 && stoneY < 9)
            {
                king = (kingX, kingY);
                stone = (stoneX, stoneY);
            }
        }
    }

    static void PrintResult()
    {
        SW.WriteLine($"{(char)('A' + king.Item1 - 1)}{king.Item2}");
        SW.WriteLine($"{(char)('A' + stone.Item1 - 1)}{stone.Item2}");
    }
}