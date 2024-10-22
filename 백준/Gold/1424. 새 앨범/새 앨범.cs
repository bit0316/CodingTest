public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int DIV_SIZE = 13;

    static void Main(string[] args)
    {
        int count = int.Parse(SR.ReadLine());
        int length = int.Parse(SR.ReadLine());
        int volume = int.Parse(SR.ReadLine());
        int result;

        result = GetReult(count, length, volume);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetReult(int count, int length, int volume)
    {
        int maxVolume;
        int maxCD;
        int remain;

        maxVolume = (volume + 1) / (length + 1);
        if (maxVolume % DIV_SIZE == 0)
        {
            maxVolume--;
        }

        maxCD = (count + maxVolume - 1) / maxVolume;
        remain = count % maxVolume;
        if (remain > 0 && remain % 13 == 0)
        {
            if (maxCD == 1)
            {
                maxCD += 1;
            }
            else if (maxVolume % 13 == 1 && remain + 2 > maxVolume)
            {
                maxCD += 1;
            }
        }

        return maxCD;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}