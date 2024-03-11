public class Program
{
    static void Main(string[] args)
    {
        int row = 5;
        int col = 16;
        char[,] text = new char[row, col];

        char[] input;
        for (int i = 0; i < row; ++i)
        {
            input = Console.ReadLine().ToCharArray();
            for (int j = 0; j < input.Length; ++j)
            {
                text[i, j] = input[j];
            }
        }

        PrintVertical(text);
    }

    static void PrintVertical(char[,] text)
    {
        int row = text.GetLength(0);
        int col = text.GetLength(1);

        for (int i = 0; i < col; ++i)
        {
            for (int j = 0; j < row; ++j)
            {
                if (text[j, i] != '\0')
                {
                    Console.Write(text[j, i]);
                }
            }
        }
    }
}