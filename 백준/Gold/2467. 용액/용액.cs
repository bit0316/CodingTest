public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] arr;

    static void Main(string[] args)
    {
        int valueA, valueB;

        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        (valueA, valueB) = GetResult();
        PrintResult(valueA, valueB);

        SR.Close();
        SW.Close();
    }

    static (int, int) GetResult()
    {
        int left = 0;
        int right = size - 1;
        int min = int.MaxValue;
        int indexA = 0;
        int indexB = 0;
        int sum;

        for (int i = 1; i < size; ++i)
        {
            sum = arr[left] + arr[right];
            if (min > Math.Abs(sum))
            {
                indexA = left;
                indexB = right;
                min = Math.Abs(sum);
            }

            if (sum < 0)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return (arr[indexA], arr[indexB]);
    }

    static void PrintResult(int valueA, int valueB)
    {
        SW.WriteLine($"{valueA} {valueB}");
    }
}