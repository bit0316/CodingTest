public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int row;
        int col;
        int count;
        string[] input;

        input = SR.ReadLine().Split();
        size = int.Parse(input[0]);
        row = int.Parse(input[1]);
        col = int.Parse(input[2]);

        count = GetCountOrder(size, row, col);
        PrintResult(count);

        SR.Close();
        SW.Close();
    }

    static int GetCountOrder(int size, int row, int col)
    {
        int count = 0;
        int posX = 0;
        int posY = 0;

        size = (int)Math.Pow(2, size);
        while (size > 0)
        {
            size /= 2;
            if (row < size + posX && col >= size + posY)
            {
                count += size * size;
                posY += size;
            }
            else if (row >= size + posX && col < size + posY)
            {
                count += size * size * 2;
                posX += size;
            }
            else if (row >= size + posX && col >= size + posY)
            {
                count += size * size * 3;
                posX += size;
                posY += size;
            }
        }

        return count;
    }

    static void PrintResult(int value)
    {
        SW.WriteLine(value);
    }
}