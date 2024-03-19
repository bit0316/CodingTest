public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int sizeA;
        int sizeB;
        HashSet<int> arrA = new HashSet<int>();
        HashSet<int> arrB = new HashSet<int>();
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

    static void SetArray(HashSet<int> arr, int size)
    {
        string[] input = SR.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            arr.Add(int.Parse(input[i]));
        }
    }

    static void SearchElement(HashSet<int> arrA, HashSet<int> arrB)
    {
        int count = arrA.Count + arrB.Count;

        foreach (int member in arrA)
        {
            if (arrB.Contains(member))
            {
                count -= 2;
            }
        }

        SW.WriteLine(count);
    }

    static void PrintResult(HashSet<int> arrA, HashSet<int> arrB)
    {
        if (arrA.Count < arrB.Count)
        {
            SearchElement(arrA, arrB);
        }
        else
        {
            SearchElement(arrB, arrA);
        }

        SW.Flush();
    }
}