public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const string BOARD = "`1234567890-=QWERTYUIOP[]\\ASDFGHJKL;'ZXCVBNM,./";

    static void Main(string[] args)
    {
        string str;
        
        while (true)
        {
            str = SR.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                break;
            }

            foreach (char ch in str)
            {
                SW.Write(ch == ' ' ? ch : BOARD[BOARD.IndexOf(ch) - 1]);
            }
            SW.WriteLine();
        }

        SR.Close();
        SW.Close();
    }
}