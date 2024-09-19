public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static (int, int)[] DIRECTION = { (-1, 0), (1, 0), (0, -1), (0, 1) };
    static int MOVE_MAX = 5;

    static int[][] map;
    static int[][] copy;
    static int index;
    static int value;
    static int size;
    static int max;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        SetMap();
        GetResult();
        PrintResult(max);

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        map = new int[size][];
        for (int i = 0; i < size; ++i)
        {
            map[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        }
    }

    static void GetResult()
    {
        max = 0;
        BackTracking(0, map);
    }

    static void BackTracking(int depth, int[][] arr)
    {
        if (depth == MOVE_MAX)
        {
            foreach (var row in arr)
            {
                max = Math.Max(max, row.Max());
            }
            return;
        }

        copy = DeepCopy(arr);
        BackTracking(depth + 1, ShiftLeft(copy));
        
        copy = DeepCopy(arr);
        BackTracking(depth + 1, ShiftRight(copy));
        
        copy = DeepCopy(arr);
        BackTracking(depth + 1, ShiftUp(copy));
        
        copy = DeepCopy(arr);
        BackTracking(depth + 1, ShiftDown(copy));
    }


    static int[][] ShiftLeft(int[][] arr)
    {
        for (int i = 0; i < size; ++i)
        {
            index = 0;
            for (int j = 1; j < size; ++j)
            {
                if (arr[i][j] == 0)
                {
                    continue;
                }

                value = arr[i][j];
                arr[i][j] = 0;
                if (arr[i][index] == 0)
                {
                    arr[i][index] = value;
                }
                else if (arr[i][index] == value)
                {
                    arr[i][index++] *= 2;
                }
                else
                {
                    arr[i][++index] = value;
                }
            }
        }

        return arr;
    }

    static int[][] ShiftRight(int[][] arr)
    {
        for (int i = 0; i < size; ++i)
        {
            index = size - 1;
            for (int j = size - 2; j >= 0; --j)
            {
                if (arr[i][j] == 0)
                {
                    continue;
                }

                value = arr[i][j];
                arr[i][j] = 0;
                if (arr[i][index] == 0)
                {
                    arr[i][index] = value;
                }
                else if (arr[i][index] == value)
                {
                    arr[i][index--] *= 2;
                }
                else
                {
                    arr[i][--index] = value;
                }
            }
        }

        return arr;
    }

    static int[][] ShiftUp(int[][] arr)
    {
        for (int i = 0; i < size; ++i)
        {
            index = 0;
            for (int j = 1; j < size; ++j)
            {
                if (arr[j][i] == 0)
                {
                    continue;
                }

                value = arr[j][i];
                arr[j][i] = 0;
                if (arr[index][i] == 0)
                {
                    arr[index][i] = value;
                }
                else if (arr[index][i] == value)
                {
                    arr[index++][i] *= 2;
                }
                else
                {
                    arr[++index][i] = value;
                }
            }
        }

        return arr;
    }

    static int[][] ShiftDown(int[][] arr)
    {
        for (int i = 0; i < size; ++i)
        {
            index = size - 1;
            for (int j = size - 2; j >= 0; --j)
            {
                if (arr[j][i] == 0)
                {
                    continue;
                }

                value = arr[j][i];
                arr[j][i] = 0;
                if (arr[index][i] == 0)
                {
                    arr[index][i] = value;
                }
                else if (arr[index][i] == value)
                {
                    arr[index--][i] *= 2;
                }
                else
                {
                    arr[--index][i] = value;
                }
            }
        }

        return arr;
    }

    static int[][] DeepCopy(int[][] arr)
    {
        int[][] copy = new int[size][];

        for (int i = 0; i < size; ++i)
        {
            copy[i] = new int[size];
            for (int j = 0; j < size; ++j)
            {
                copy[i][j] = arr[i][j];
            }
        }

        return copy;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}