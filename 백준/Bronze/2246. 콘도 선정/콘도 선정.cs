public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int count;
    static int[][] arr;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = new int[size][];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        }

        bool isValid;
        for (int i = 0; i < size; ++i)
        {
            isValid = true;
            for (int j = 0; j < size; ++j)
            {
                if (i == j)
                {
                    continue;
                }

                if ((arr[i][0] >= arr[j][0] && arr[i][1] >= arr[j][1]) ||
                    (arr[i][1] >= arr[j][1] && arr[i][0] >= arr[j][0]))
                {
                    isValid = false;
                    continue;
                }
            }

            if (isValid)
            {
                count++;
            }
        }
        SW.WriteLine(count);

        SR.Close();
        SW.Close();
    }
}