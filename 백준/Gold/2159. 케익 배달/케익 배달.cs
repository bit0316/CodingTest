public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[][] pos;
    static long[][] arr;
    static int[] DIR_X = { 0, -1, 0, 1, 0 };
    static int[] DIR_Y = { 0, 0, -1, 0, 1 };
    static int SIZE_MAX = 100000;
    static string[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        pos = new int[size + 1][];
        arr = new long[size + 1][];

        for (int i = 0; i <= size; ++i)
        {
            pos[i] = new int[2];
            arr[i] = new long[5];
            input = SR.ReadLine().Split();
            pos[i][0] = int.Parse(input[0]) - 1;
            pos[i][1] = int.Parse(input[1]) - 1;
            Array.Fill(arr[i], long.MaxValue);
        }
        SW.WriteLine(GetDFS(0, 0));

        SR.Close();
        SW.Close();
    }

    static long GetDFS(int depth, int dir)
    {
        if (depth == size)
        {
            return 0;
        }

        if (arr[depth][dir] != long.MaxValue)
        {
            return arr[depth][dir];
        }

        int posX = pos[depth][0] + DIR_X[dir];
        int posY = pos[depth][1] + DIR_Y[dir];
        int curX, curY;

        for (int i = 0; i < 5; ++i)
        {
            curX = pos[depth + 1][0] + DIR_X[i];
            curY = pos[depth + 1][1] + DIR_Y[i];
            if (curX < 0 || curX >= SIZE_MAX || curY < 0 || curY >= SIZE_MAX)
            {
                continue;
            }

            arr[depth][dir] = Math.Min(arr[depth][dir], GetDFS(depth + 1, i) + Math.Abs(posX - curX) + Math.Abs(posY - curY));
        }

        return arr[depth][dir];
    }
}