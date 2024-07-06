public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            GetResult();
        }

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int row = input[0];
        int col = input[1];
        int moveX = input[2];
        int moveY = input[3];
        bool[,] visited = new bool[row + 1, col + 1];

        int count = 0;
        for (int i = 1; i <= row; ++i)
        {
            for (int j = 1; j <= col; ++j)
            {
                if (i <= moveX || j <= moveY || !visited[i - moveX, j - moveY])
                {
                    visited[i, j] = true;
                    count++;
                }
            }
        }

        SW.WriteLine(count);
    }
}