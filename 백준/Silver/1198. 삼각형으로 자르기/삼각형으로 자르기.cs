public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static (int, int)[] coords;

    static void Main(string[] args)
    {
        double result;

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

        coords = new (int, int)[size];
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            coords[i] = (input[0], input[1]);
        }
    }

    static double GetResult()
    {
        double max = 0;
        double sum;

        for (int i = 0; i < size - 2; ++i)
        {
            for (int j = i + 1; j < size - 1; ++j)
            {
                for (int k = j + 1; k < size; ++k)
                {
                    sum = (coords[i].Item1 * coords[j].Item2 + coords[j].Item1 * coords[k].Item2 + coords[k].Item1 * coords[i].Item2)
                        - (coords[j].Item1 * coords[i].Item2 + coords[k].Item1 * coords[j].Item2 + coords[i].Item1 * coords[k].Item2);
                    max = Math.Max(max, Math.Abs(sum) / 2);
                }
            }
        }

        return max;
    }

    static void PrintResult(double result)
    {
        SW.WriteLine(result);
    }
}