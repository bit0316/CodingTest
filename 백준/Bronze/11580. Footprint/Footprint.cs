public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<char, (int, int)> DIRECTIONS = new Dictionary<char, (int, int)>
    {
        { 'E', (0, 1) }, { 'W', (0, -1) }, { 'S', (-1, 0) }, { 'N', (1, 0) }
    };

    static void Main(string[] args)
    {
        HashSet<(int, int)> hash = new HashSet<(int, int)>();
        int posX = 0;
        int posY = 0;
        int size;
        string input;

        size = int.Parse(SR.ReadLine());
        input = SR.ReadLine();

        hash.Add((posX, posY));
        foreach (char ch in input)
        {
            posX += DIRECTIONS[ch].Item1;
            posY += DIRECTIONS[ch].Item2;
            hash.Add((posX, posY));
        }

        SW.WriteLine(hash.Count);

        SR.Close();
        SW.Close();
    }
}