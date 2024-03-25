public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] arr;
        HashSet<int> hash;

        size = int.Parse(SR.ReadLine());
        hash = new HashSet<int>();
        SetArray(hash, size);

        size = int.Parse(SR.ReadLine());
        arr = new int[size];
        SetArray(arr, size);

        PrintResult(hash, arr);

        SR.Close();
        SW.Close();
    }

    static void SetArray(HashSet<int> hash, int size)
    {
        int[] arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        for (int i = 0; i < size; ++i)
        {
            hash.Add(arr[i]);
        }
    }

    static void SetArray(int[] arr, int size)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        for (int i = 0; i < size; ++i)
        {
            arr[i] = input[i];
        }
    }

    static bool IsValid(HashSet<int> hash, int num)
    {
        return hash.Contains(num);
    }

    static void PrintResult(HashSet<int> hash, int[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            SW.WriteLine(IsValid(hash, arr[i]) ? 1 : 0);
        }

        SW.Flush();
    }
}