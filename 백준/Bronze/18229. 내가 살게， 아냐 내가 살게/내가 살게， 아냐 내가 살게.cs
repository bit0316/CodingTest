public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int people, chance, goal;
        int[][] arr;
        int[] input;
        string result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        people = input[0];
        chance = input[1];
        goal = input[2];

        arr = SetArray(people);
        result = GetResult(people, chance, goal, arr);
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

        return arr;
    }

    static string GetResult(int people, int chance, int goal, int[][] arr)
    {
        int[] length = new int[people];

        for (int i = 0; i < chance; ++i)
        {
            for (int j = 0; j < people; ++j)
            {
                length[j] += arr[j][i];
                if (length[j] >= goal)
                {
                    return $"{j + 1} {i + 1}";
                }
            }
        }

        return "";
    }

    static void PrintResult(string result)
    {
        SW.WriteLine(result);
    }
}