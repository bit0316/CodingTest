public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string[] arr;
        int size;

        size = int.Parse(SR.ReadLine());

        arr = SetArray(size);
        PrintResult(arr, size, 0, 0);

        SR.Close();
        SW.Close();
    }

    static string[] SetArray(int size)
    {
        string[] arr = new string[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = SR.ReadLine();
        }

        return arr;
    }

    static void PrintResult(string[] arr, int size, int row, int col)
    {
        char ch = arr[row][col];
        int mid;

        for (int i = row; i < row + size; ++i)
        {
            for (int j = col; j < col + size; ++j)
            {
                if (arr[i][j] != ch)
                {
                    mid = size / 2;
                    SW.Write("(");
                    PrintResult(arr, mid, row, col);
                    PrintResult(arr, mid, row, col + mid);
                    PrintResult(arr, mid, row + mid, col);
                    PrintResult(arr, mid, row + mid, col + mid);
                    SW.Write(")");
                    return;
                }
            }
        }
        SW.Write(ch);
    }
}