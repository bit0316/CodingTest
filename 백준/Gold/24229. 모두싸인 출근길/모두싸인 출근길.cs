public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int[][] arr;
        int size;
        int result;

        size = int.Parse(SR.ReadLine());
        arr = SetArray(size);
        result = GetReult(size, arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[][] SetArray(int size)
    {
        int[][] arr = new int[size][];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        }

        return arr.OrderBy(x => x[0]).ToArray();
    }

    static int GetReult(int size, int[][] arr)
    {
        List<(int, int)> list = new List<(int, int)>();
        int index = 0;
        int max = 0;
        int count;
        int left;
        int right;

        left = arr[0][0];
        right = arr[0][1];
        for (int i = 1; i < size; ++i)
        {
            if (right >= arr[i][0])
            {
                right = Math.Max(right, arr[i][1]);
                continue;
            }
            list.Add((left, right));
            left = arr[i][0];
            right = arr[i][1];
        }
        list.Add((left, right));

        count = list.Count;
        for (int i = 0; i < count; ++i)
        {
            if (max >= list[i].Item1)
            {
                index = i;
                max = Math.Max(max, 2 * list[i].Item2 - list[i].Item1);
            }
        }

        return list[index].Item2;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}