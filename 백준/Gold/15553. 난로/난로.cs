public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int friends;
    static int matches;
    static int[] arr;

    static void Main(string[] args)
    {
        int result;

        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        friends = input[0];
        matches = input[1];

        SetArray();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        arr = new int[friends];
        for (int i = 0; i < friends; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }
    }

    static int GetResult()
    {
        List<int> list = new List<int>();
        int result = friends;
        int count = friends;
        int index = 0;

        for (int i = 1; i < friends; ++i)
        {
            list.Add(arr[i] - arr[i - 1] - 1);
        }
        list.Sort();

        while (count > matches)
        {
            result += list[index++];
            count--;
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}