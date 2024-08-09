public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<int, int> movement = new Dictionary<int, int>();

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());

        SetMovement(size);
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetMovement(int size)
    {
        int position;
        int distance;
        string[] input;

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            position = int.Parse(input[0]);
            distance = int.Parse(input[2]);

            if (input[1] == "L")
            {
                movement.Add(position, position - distance);
            }
            else
            {
                movement.Add(position, position + distance);
            }
        }
    }

    static int GetResult()
    {
        int start;
        int end;

        start = int.Parse(SR.ReadLine());
        while (movement.TryGetValue(start, out end))
        {
            start = end;
        }

        return start;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}