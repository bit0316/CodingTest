public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static string[] universities = { "Soongsil", "Korea", "Hanyang" };

    static void Main(string[] args)
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        int[] arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        for (int i = 0; i < arr.Length; ++i)
        {
            dict.Add(arr[i], universities[i]);
        }

        if (arr.Sum() >= 100)
        {
            SW.WriteLine("OK");
        }
        else
        {
            SW.WriteLine(dict[arr.Min()]);
        }

        SR.Close();
        SW.Close();
    }
}