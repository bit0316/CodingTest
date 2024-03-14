public class Program
{
    static void Main(string[] args)
    {
        int posX;
        int posY;
        int posW;
        int posH;
        int result;
        string[] input;

        input = Console.ReadLine().Split();
        posX = int.Parse(input[0]);
        posY = int.Parse(input[1]);
        posW = int.Parse(input[2]);
        posH = int.Parse(input[3]);
        
        result = GetMinDistance(posX, posY, posW, posH);
        Console.WriteLine(result);
    }
        
    static int GetMinDistance(int posX, int posY, int posW, int posH)
    {
        int minX;
        int minY;
        int result;

        minX = posX * 2 > posW ? posW - posX : posX;
        minY = posY * 2 > posH ? posH - posY : posY;
        result = minX > minY ? minY : minX;

        return result;
    }
}