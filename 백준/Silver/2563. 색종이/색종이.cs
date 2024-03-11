public class Program
{
    static void Main(string[] args)
    {
        int count;
        int row = 100;
        int col = 100;
        int paperSize = 10;
        int[,] arr = new int[row, col];

        count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; ++i)
        {
            SetPaper(arr, paperSize);
        }

        Console.WriteLine(CalArray(arr));
    }

    static void SetPaper(int[,] arr, int paperSize)
    {
        int posX;
        int posY;
        string[] input;

        input = Console.ReadLine().Split();
        posX = int.Parse(input[0]);
        posY = int.Parse(input[1]);

        for (int i = posX; i < posX + paperSize; ++i)
        {
            for (int j = posY; j < posY + paperSize; ++j)
            {
                arr[i, j] = 1;
            }
        }
    }

    static int CalArray(int[,] arr)
    {
        int sum = 0;
        int row = arr.GetLength(0);
        int col = arr.GetLength(1);

        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                sum += arr[i, j];
            }
        }

        return sum;
    }
}