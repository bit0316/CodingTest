public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTION = { (0, 1), (1, -1), (1, 0), (1, 1) };
    static string[] map;
    static string[] word;
    static int row;
    static int col;
    static int count;
    static int[] input;

    static void Main(string[] args)
    {
        int size;

        size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            row = input[0];
            col = input[1];
            SetMap();
            SetWord();
            GetResult();
        }

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new string[row];
        for (int i = 0; i < row; ++i)
        {
            map[i] = SR.ReadLine().ToLower();
        }
    }

    static void SetWord()
    {
        count = int.Parse(SR.ReadLine());

        word = new string[count];
        for (int i = 0; i < count; ++i)
        {
            word[i] = SR.ReadLine().ToLower();
        }
    }

    static void GetResult()
    {
        for (int i = 0; i < count; ++i)
        {
            GetPosition(word[i]);
        }

        SW.WriteLine();
    }

    static void GetPosition(string text)
    {
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (map[i][j] == text[0])
                {
                    foreach (var dir in DIRECTION)
                    {
                        if (IsValid(text, i - dir.Item1, j - dir.Item2, -dir.Item1, -dir.Item2, 1) ||
                            IsValid(text, i + dir.Item1, j + dir.Item2, dir.Item1, dir.Item2, 1))
                        {
                            SW.WriteLine($"{i + 1} {j + 1}");
                            return;
                        }
                    }
                }
            }
        }

        SW.WriteLine($"{row} {col}");
    }

    static bool IsValid(string text, int posX, int posY, int dirX, int dirY, int index)
    {
        bool valid = false;

        if (index == text.Length)
        {
            return true;
        }

        if (posX >= 0 && posY >= 0 && posX < row && posY < col && map[posX][posY] == text[index])
        {
            valid = IsValid(text, posX + dirX, posY + dirY, dirX, dirY, index + 1);
        }

        return valid;
    }
}