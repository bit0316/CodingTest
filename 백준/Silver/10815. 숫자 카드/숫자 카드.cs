public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        Dictionary<int, bool> cards = new Dictionary<int, bool>();
        int[] arr;

        size = int.Parse(sr.ReadLine());
        SetCards(cards, size);

        size = int.Parse(sr.ReadLine());
        arr = new int[size];
        SetCards(arr, size);

        PrintResult(cards, arr);

        sr.Close();
        sw.Close();
    }

    static void SetCards(Dictionary<int, bool> cards, int size)
    {
        string[] input = sr.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            cards.Add(int.Parse(input[i]), true);
        }
    }

    static void SetCards(int[] arr, int size)
    {
        string[] input = sr.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }
    }

    static bool TryGetCard(Dictionary<int, bool> cards, int card)
    {
        if (cards.TryGetValue(card, out bool result))
        {
            return true;
        }
        return false;
    }

    static void PrintResult(Dictionary<int, bool> cards, int[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            if (TryGetCard(cards, arr[i]))
            {
                sw.Write("1 ");
            }
            else
            {
                sw.Write("0 ");
            }
        }

        sw.Flush();
    }
}