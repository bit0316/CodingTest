public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        if (SR.ReadLine().ToUpper() == "N")
        {
            SW.WriteLine("Naver D2");
        }
        else
        {
            SW.WriteLine("Naver Whale");
        }

        SR.Close();
        SW.Close();
    }
}