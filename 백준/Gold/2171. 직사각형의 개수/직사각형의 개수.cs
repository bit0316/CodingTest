public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<(int, int)> coordA = new List<(int, int)>();
    static HashSet<(int, int)> coordB = new HashSet<(int, int)>();
    static int size;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());

        SetCoord();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetCoord()
    {
        int[] input;

        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            coordA.Add((input[0], input[1]));
            coordB.Add((input[0], input[1]));
        }
    }

    static int GetResult()
    {
        int count = 0;

        for (int i = 0; i < size; ++i)
        {
            for (int j = i + 1; j < size; ++j)
            {
                if (coordA[i].Item1 != coordA[j].Item1 && coordA[i].Item2 != coordA[j].Item2 &&
                    coordB.Contains((coordA[i].Item1, coordA[j].Item2)) &&
                    coordB.Contains((coordA[j].Item1, coordA[i].Item2)))
                {
                    count++;
                }
            }
        }

        return count / 2;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}