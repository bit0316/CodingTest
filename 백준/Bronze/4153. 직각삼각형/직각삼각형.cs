public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = 3;
        int[] input = new int[size];
        int[] output = new int[size];

        while (true)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            if (input[0] == 0 && input[1] == 0 && input[2] == 0)
            {
                break;
            }

            PrintRightTriangle(input);
        }

        SW.Flush();
        SR.Close();
        SW.Close();
    }

    static void PrintRightTriangle(int[] arr)
    {
        string result;

        arr = arr.OrderBy(x => x).ToArray();
        result  = arr[0] * arr[0] + arr[1] * arr[1] == arr[2] * arr[2] ? "right" : "wrong";
        SW.WriteLine(result);
    }
}