public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string input = SR.ReadLine();
        string search = SR.ReadLine();
        int sizeInput = input.Length;
        int sizeSearch = search.Length;

        input = input.Replace(search, "");
        SW.WriteLine((sizeInput - input.Length) / sizeSearch);

        SR.Close();
        SW.Close();
    }
}