public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int row;
    static int point;
    static (int, int)[] pos;

    static void Main(string[] args)
    {
        long result;

        row = int.Parse(SR.ReadLine());
        point = int.Parse(SR.ReadLine());

        SetPosition();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetPosition()
    {
        int[] input;

        pos = new (int, int)[point];
        for (int i = 0; i < point; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            pos[i] = (input[0], input[1]);
        }
        Array.Sort(pos);
    }

    static long GetResult()
    {
        if (!IsValid())
        {
            return 0;
        }

        int[,] arr = new int[row, row];
        int cur = pos[0].Item1;
        int index = 0;
        long sum = 0;

        arr[0, 0] = 1;
        if (cur == 0)
        {
            while (index < point)
            {
                if (pos[index].Item1 != 0)
                {
                    cur = pos[index].Item1;
                    break;
                }
                index++;
            }
        }

        for (int i = 1; i < row; ++i)
        {
            arr[i, 0] = arr[i - 1, 0];
            for (int j = 1; j < i; ++j)
            {
                arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
            }
            arr[i, i] = arr[i - 1, i - 1];

            if (i == cur)
            {
                for (int j = 0; j <= i; ++j)
                {
                    if (j != pos[index].Item2)
                    {
                        arr[i, j] = 0;
                    }
                }

                while (index < point)
                {
                    if (pos[index].Item1 == cur)
                    {
                        index++;
                    }
                    else
                    {
                        cur = pos[index].Item1;
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < row; ++i)
        {
            sum += arr[row - 1, i];
        }

        return sum;
    }

    static bool IsValid()
    {
        for (int i = 0; i < point - 1; ++i)
        {
            if (pos[i].Item1 == pos[i + 1].Item1 && pos[i].Item2 != pos[i + 1].Item2 && pos[i].Item1 >= row)
            {
                return false;
            }
        }

        if (pos[point - 1].Item1 >= row)
        {
            return false;
        }

        return true;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}