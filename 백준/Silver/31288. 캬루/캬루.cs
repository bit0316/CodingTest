public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        string[] input;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; i++)
        {
            input = SR.ReadLine().Split();
            GetResult(int.Parse(input[0]), input[1]);
        }

        SR.Close();
        SW.Close();
    }

    static void GetResult(int numA, string numB)
    {
        if (numA == 1)
        {
            SW.WriteLine("4 2");
            return;
        }

        int temp;
        int remainder = 0;
        foreach (char ch in numB)
        {
            temp = ch - '0';
            remainder = (temp + remainder) % 3;
        }

        int next;
        string start;
        string end;
        for (int i = 0; i < numA; i++)
        {
            temp = numB[i] - '0';
            next = (temp - remainder) <= 0 ? (temp - remainder + 3) : (temp - remainder);
            start = numB.Substring(0, i);
            end = numB.Length - 1 > i ? numB.Substring(i + 1) : "";

            SW.WriteLine($"{start + next + end} 3");
        }
    }
}