public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int index = 4;
    static int[] arr = new int[11];

    static void Main(string[] args)
    {
        int size;
        int num;
        int result;

        size = int.Parse(SR.ReadLine());

        arr[1] = 1;
        arr[2] = 2;
        arr[3] = 4;
        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(SR.ReadLine());
            result = GetResult(num);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult(int num)
    {
        while (index <= num)
        {
            arr[index] = arr[index - 1] + arr[index - 2] + arr[index - 3];
            index++;
        }

        return arr[num];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}