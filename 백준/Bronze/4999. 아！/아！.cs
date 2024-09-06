public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        bool isValid;
        string strA;
        string strB;

        strA = SR.ReadLine();
        strB = SR.ReadLine();

        isValid = GetResult(strA, strB);
        PrintResult(isValid);

        SR.Close();
        SW.Close();
    }

    static bool GetResult(string strA, string strB)
    {
        return strA.Length < strB.Length;
    }

    static void PrintResult(bool isValid)
    {
        if (isValid)
        {
            SW.WriteLine("no");
        }
        else
        {
            SW.WriteLine("go");
        }
    }
}