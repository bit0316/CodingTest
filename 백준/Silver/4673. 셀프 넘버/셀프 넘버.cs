public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_SIZE = 10001;
    static bool[] visited = new bool[MAX_SIZE];

    static void Main(string[] args)
    {
        for (int i = 1; i < MAX_SIZE; ++i)
        {
            CheckSelfNumber(i);
            PrintSelfNumber(i);
        }

        SR.Close();
        SW.Close();
    }

    static void CheckSelfNumber(int num)
    {
        int index = num;
        while (num > 0)
        {
            index += num % 10;
            num /= 10;
        }

        if (index < MAX_SIZE)
        {
            visited[index] = true;
        }
    }

    static void PrintSelfNumber(int num)
    {
        if (!visited[num])
        {
            SW.WriteLine(num);
        }
    }
}