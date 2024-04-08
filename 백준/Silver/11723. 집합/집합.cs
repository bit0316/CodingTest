public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int bitmask = 0;
    static string[] input;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();

            switch (input[0])
            {
                case "add":
                    Add(int.Parse(input[1]));
                    break;
                case "remove":
                    Remove(int.Parse(input[1]));
                    break;
                case "check":
                    PrintResult(Check(int.Parse(input[1])));
                    break;
                case "toggle":
                    Toggle(int.Parse(input[1]));
                    break;
                case "all":
                    All();
                    break;
                case "empty":
                    Empty();
                    break;
            }
        }

        SR.Close();
        SW.Close();
    }

    static void Add(int value)
    {
        bitmask |= 1 << value;
    }

    static void Remove(int value)
    {
        bitmask &= ~(1 << value);
    }

    static int Check(int value)
    {
        return (bitmask & (1 << value)) != 0 ? 1 : 0;
    }

    static void Toggle(int value)
    {
        bitmask ^= 1 << value;
    }

    static void All()
    {
        bitmask = ~0;
    }

    static void Empty()
    {
        bitmask = 0;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}