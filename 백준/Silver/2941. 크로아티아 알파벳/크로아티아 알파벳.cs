public class Program
{
    static void Main(string[] args)
    {
        string[] croatia = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
        string input;

        input = Console.ReadLine();

        for (int i = 0; i < croatia.Length; ++i)
        {
            input = input.Replace(croatia[i], " ");
        }

        Console.WriteLine(input.Length);
    }
}