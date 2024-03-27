public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());
    static int MAX_HEIGHT = 256;

    static void Main(string[] args)
    {
        int row;
        int col;
        int blocks;
        string[] input;

        input = SR.ReadLine().Split();
        row = int.Parse(input[0]);
        col = int.Parse(input[1]);
        blocks = int.Parse(input[2]);

        PrintBestArea(row, col, blocks);

        SR.Close();
        SW.Close();
    }

    static void PrintBestArea(int row, int col, int blocks)
    {
        int[,] area = new int[row, col];
        int minHeight = MAX_HEIGHT;
        int maxHeight = 0;
        int bestHeight = 0;
        int remainBlocks;
        int elapsedTime;
        int bestTime = MAX_HEIGHT * row * col * 2;
        int[] input;

        for (int i = 0; i < row; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 0; j < col; ++j)
            {
                area[i, j] = input[j];
            }
            minHeight = input.Min() < minHeight ? input.Min() : minHeight;
            maxHeight = input.Max() > maxHeight ? input.Max() : maxHeight;
        }

        for (int i = minHeight; i <= maxHeight; ++i)
        {
            elapsedTime = 0;
            remainBlocks = blocks;
            foreach (int height in area)
            {
                if (height < i)
                {
                    elapsedTime += i - height;
                    remainBlocks -= i - height;
                }
                else if (height > i)
                {
                    elapsedTime += (height - i) * 2;
                    remainBlocks += height - i;
                }
            }

            if (elapsedTime <= bestTime && remainBlocks >= 0)
            {
                bestTime = elapsedTime;
                bestHeight = i;
            }
        }

        SW.WriteLine($"{bestTime} {bestHeight}");
    }
}