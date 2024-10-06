public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int move = input[0];
        int round = input[1];
        bool result;

        result = GetResult(move, round);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static bool GetResult(int move, int round)
    {
        List<(int, int)>[] list = new List<(int, int)>[move];
        string movement = SR.ReadLine();
        int posX = 0;
        int posY = 0;

        for (int i = 0; i < move; ++i)
        {
            list[i] = new List<(int, int)>();
        }

        for (int i = 0; i < round; ++i)
        {
            for (int j = 0; j < move; ++j)
            {
                if (movement[j] == 'U')
                {
                    posY++;
                }
                else if (movement[j] == 'D')
                {
                    posY--;
                }
                else if (movement[j] == 'L')
                {
                    posX--;
                }
                else
                {
                    posX++;
                }

                if (posX == 0 && posY == 0)
                {
                    return true;
                }

                if (list[j].Contains((posX, posY)) || Math.Abs(posX) > move || Math.Abs(posY) > move)
                {
                    return false;
                }

                list[j].Add((posX, posY));
            }
        }

        return false;
    }

    static void PrintResult(bool valid)
    {
        SW.WriteLine(valid ? "YES" : "NO");
    }
}