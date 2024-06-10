public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        string strA = SR.ReadLine();
        string strB = SR.ReadLine();
        string strC = SR.ReadLine();

        SW.WriteLine(int.Parse(strA) + int.Parse(strB) - int.Parse(strC));
        SW.WriteLine(int.Parse(strA + strB) - int.Parse(strC));

        SR.Close();
        SW.Close();
    }
}