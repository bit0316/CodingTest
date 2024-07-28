public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static string CONSONANTS = "bcdfghjklmnpqrstvwxyz";
    static string VOWELS = "aeiou";
    static int size;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        GetResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        int count = 1;
        foreach (char a in CONSONANTS)
        {
            foreach (char b in CONSONANTS)
            {
                foreach (char c in VOWELS)
                {
                    foreach (char d in CONSONANTS)
                    {
                        SW.WriteLine($"{a}{b}{c}{d}");
                        if (count >= size)
                        {
                            return;
                        }
                        count++;
                    }
                }
            }
        }
    }
}