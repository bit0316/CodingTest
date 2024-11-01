public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;
        int[] input;

        size = int.Parse(SR.ReadLine().Trim());
        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            result = GetResult(input[0], input[1]);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult(int count, int length)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int pair = 0;
        int upper;
        char[] chArr;
        string[] arr;
        string car;

        arr = SR.ReadLine().Split();
        foreach (string str in arr)
        {
            upper = 0;
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upper++;
                }
            }

            chArr = str.ToLower().ToCharArray();
            Array.Sort(chArr);

            car = upper + new string(chArr);
            if (dict.ContainsKey(car))
            {
                pair += dict[car];
                dict[car]++;
            }
            else
            {
                dict[car] = 1;
            }
        }

        return pair;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}