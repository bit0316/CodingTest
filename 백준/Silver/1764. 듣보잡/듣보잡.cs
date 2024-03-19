public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int sizeA;
        int sizeB;
        HashSet<string> arrA = new HashSet<string>();
        HashSet<string> arrB = new HashSet<string>();
        string[] input;

        input = SR.ReadLine().Split();
        sizeA = int.Parse(input[0]);
        sizeB = int.Parse(input[1]);

        SetArray(arrA, sizeA);
        SetArray(arrB, sizeB);
        PrintResult(arrA, arrB);

        SR.Close();
        SW.Close();
    }

    static void SetArray(HashSet<string> arr, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            arr.Add(SR.ReadLine());
        }
    }

    static void SearchMember(HashSet<string> arrA, HashSet<string> arrB)
    {
        int count = 0;
        HashSet<string> list = new HashSet<string>();

        foreach (string member in arrA)
        {
            if (arrB.Contains(member))
            {
                list.Add(member);
                count++;
            }
        }

        SW.WriteLine(count);
        foreach (string member in list.OrderBy(x => x))
        {
            SW.WriteLine(member);
        }
    }

    static void PrintResult(HashSet<string> arrA, HashSet<string> arrB)
    {
        if (arrA.Count < arrB.Count)
        {
            SearchMember(arrA, arrB);
        }
        else
        {
            SearchMember(arrB, arrA);
        }

        SW.Flush();
    }
}