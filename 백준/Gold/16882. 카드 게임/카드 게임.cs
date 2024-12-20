public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int SIZE_MAX = 100000;

    static void Main(string[] args)
    {
        int max;
        int size;
        int[] arr;
        string[] input;

        size = int.Parse(SR.ReadLine());
        input = SR.ReadLine().Split();

        arr = new int[SIZE_MAX + 1];
        for (int i = 0; i < size; ++i)
        {
            arr[int.Parse(input[i])]++;
        }

        max = SIZE_MAX;
        while (max >= 0 && arr[max] == 0)
        {
            max--;
        }

        SW.WriteLine(arr[max] == size && arr[max] % 2 == 0 ? "cubelover" : "koosaga");

        SR.Close();
        SW.Close();
    }
}